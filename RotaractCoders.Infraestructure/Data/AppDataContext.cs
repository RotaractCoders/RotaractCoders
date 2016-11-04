using MongoDB.Driver;
using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;

namespace RotaractCoders.Infraestructure.Data
{
    public class AppDataContext : IDisposable
    {

        public MongoCollection<Clube> Clube;
        public MongoCollection<Distrito> Distrito;
        public MongoCollection<Projeto> Projeto;
        private MongoClient _client;
        private MongoDatabase _dataBase;
        private MongoServer _server;

        public AppDataContext(string connectionString, string dataBase)
        {
            _client = new MongoClient(connectionString);
            _server = _client.GetServer();
            _dataBase = _server.GetDatabase(dataBase);

            Clube = _dataBase.GetCollection<Clube>(nameof(Clube));
            Distrito = _dataBase.GetCollection<Distrito>(nameof(Distrito));
            Projeto = _dataBase.GetCollection<Projeto>(nameof(Projeto));
        }

        public void Dispose()
        {
            _server.Disconnect();
            GC.SuppressFinalize(this);
        }
    }
}
