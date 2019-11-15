using AccessData.Chat.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Logic.Chat.Services
{
    public class ModelService : IModelService
    {
        private readonly IMongoCollection<Model> _model;
        private readonly IDataBaseSettings _settings;

        public ModelService(IDataBaseSettings settings)
        {
            _settings = settings;
            var client = new MongoClient(_settings.ConnectionString);
            var db = client.GetDatabase(_settings.DatabaseName);

            _model = db.GetCollection<Model>(_settings.ModelCollectionName);
        }

        public Model Get(string id) => _model.Find<Model>(m => m.Id == id).FirstOrDefault();
        public List<Model> Get() => _model.Find<Model>(m => true).ToList();

    }
}
