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

            var inicio = 5047;
            var sucesso = true;

            while (sucesso)
            {
                sucesso = omirBrasilApplication.PersistirProjeto(inicio);

                Console.WriteLine($"{inicio} - {(sucesso ? "Sucesso" : "Erro")}");

                inicio++;
            }

            Console.ReadKey();
        }
    }
}