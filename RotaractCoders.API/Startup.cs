using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Practices.ObjectBuilder2;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.ObjectBuilder;
using Newtonsoft.Json.Serialization;
using RotaractCoders.API.Controllers;
using RotaractCoders.CrossCutting;
using System;

namespace RotaractCoders.API
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();

            services.AddMvc()
                .AddJsonOptions
                (
                    options => options.SerializerSettings.ContractResolver = new DefaultContractResolver()
                );

            var unityServiceProvider = new UnityServiceProvider();

            var container = unityServiceProvider.UnityContainer;

            DependencyRegister.Register(container, "mongodb://localhost:27017", "Rotaract");

            services.AddSingleton<IControllerActivator>(new UnityControllerActivator(container));

            var defaultProvider = services.BuildServiceProvider();

            container.AddExtension(new UnityFallbackProviderExtension(defaultProvider));

            return unityServiceProvider;
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseMvc();
        }

        public class UnityServiceProvider : IServiceProvider
        {
            private IUnityContainer _container;

            public IUnityContainer UnityContainer => _container;

            public UnityServiceProvider()
            {
                _container = new UnityContainer();
            }

            #region Implementation of IServiceProvider

            public object GetService(Type serviceType)
            {
                return _container.Resolve(serviceType);
            }

            #endregion
        }

        public class UnityControllerActivator : IControllerActivator
        {
            private IUnityContainer _unityContainer;

            public UnityControllerActivator(IUnityContainer container)
            {
                _unityContainer = container;
            }

            #region Implementation of IControllerActivator

            public object Create(ControllerContext context)
            {
                return _unityContainer.Resolve(context.ActionDescriptor.ControllerTypeInfo.AsType());
            }


            public void Release(ControllerContext context, object controller)
            {

            }

            #endregion
        }

        public class UnityFallbackProviderExtension : UnityContainerExtension
        {
            #region Const

            public const string FALLBACK_PROVIDER_NAME = "UnityFallbackProvider";

            #endregion

            #region Vars

            private IServiceProvider _defaultServiceProvider;

            #endregion

            #region Constructors

            public UnityFallbackProviderExtension(IServiceProvider defaultServiceProvider)
            {
                _defaultServiceProvider = defaultServiceProvider;
            }

            #endregion

            #region Overrides of UnityContainerExtension
            
            protected override void Initialize()
            {
                Context.Container.RegisterInstance(FALLBACK_PROVIDER_NAME, _defaultServiceProvider);

                var strategy = new UnityFallbackProviderStrategy(Context.Container);
                
                Context.Strategies.Add(strategy, UnityBuildStage.PreCreation);
            }

            #endregion
        }

        public class UnityFallbackProviderStrategy : BuilderStrategy
        {
            private IUnityContainer _container;

            public UnityFallbackProviderStrategy(IUnityContainer container)
            {
                _container = container;
            }

            #region Overrides of BuilderStrategy

            public override void PreBuildUp(IBuilderContext context)
            {
                var key = context.OriginalBuildKey;

                if (!_container.IsRegistered(key.Type))
                {
                    context.Existing = _container.Resolve<IServiceProvider>(UnityFallbackProviderExtension.FALLBACK_PROVIDER_NAME).GetService(key.Type);
                }

                base.PreBuildUp(context);
            }

            #endregion
        }
    }
}
