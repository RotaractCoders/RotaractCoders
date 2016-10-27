using MongoDB.Driver;
using RotaractCoders.Domain.ProjetosSociais.Entities;

namespace RotaractCoders.Infraestructure.Data
{
    public class AppDataContext
    {
        public MongoCollection<Clube> Clube;
        public MongoCollection<Distrito> Distrito;
        public MongoCollection<Projeto> Projeto;

        public AppDataContext()
        {
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("Rotaract");

            Clube = database.GetCollection<Clube>(nameof(Clube));
            Distrito = database.GetCollection<Distrito>(nameof(Distrito));
            Projeto = database.GetCollection<Projeto>(nameof(Projeto));
        }
    }
}
