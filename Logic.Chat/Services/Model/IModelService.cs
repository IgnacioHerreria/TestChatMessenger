using AccessData.Chat.Models;
using System.Collections.Generic;

namespace Logic.Chat.Services
{
    public interface IModelService
    {
        Model Get(string id);
        List<Model> Get();
    }
}
