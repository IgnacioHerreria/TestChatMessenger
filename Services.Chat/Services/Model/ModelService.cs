using AccessData.Chat.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Utils.Chat.Dto;

namespace Services.Chat.Services
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

        public DtoResponse Get(string id)
        {
            Model modelo = _model.Find<Model>(m => m.Id == id).FirstOrDefault();
            if (modelo == null)
                return new DtoResponse() { };
            return new DtoResponse()
            {
                Id = modelo.Id,
                Dt1 = modelo.Name,
                Dt2 = modelo.Category,
            };
        }


        public IEnumerable<DtoResponse> Get() => _model.Find<Model>(m => true)?.ToEnumerable().Select(x => new DtoResponse
        {
            Id = x.Id,
            Dt1 = x.Name,
            Dt2 = x.Category,
        });


    }
}
