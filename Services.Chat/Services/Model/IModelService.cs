using System.Collections.Generic;
using Utils.Chat.Dto;

namespace Services.Chat.Services
{
    public interface IModelService
    {
        DtoResponse Get(string id);
        IEnumerable<DtoResponse> Get();
    }
}
