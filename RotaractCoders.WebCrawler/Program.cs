using System;
using Microsoft.Practices.Unity;
using RotaractCoders.CrossCutting;
using RotaractCoders.Domain.ProjetosSociais.Contracts.Application;

namespace RotaractCoders.WebCrawler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new UnityContainer();
            DependencyRegister.Register(container, "mongodb://localhost:27017", "Rotaract");

            var omirBrasilApplication = container.Resolve<IOmirBrasilApplication>();

            Console.WriteLine(omirBrasilApplication.PersistirProjeto(10289));
            Console.ReadKey();
        }
    }
}