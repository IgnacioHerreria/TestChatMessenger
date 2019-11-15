using System.Collections.Generic;
using AccessData.Chat.Models;
using Logic.Chat.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Chat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MdlController : Controller
    {
        private readonly IModelService _modelService;

        public MdlController(IModelService modelService)
        {
            _modelService = modelService;
        }



        [HttpGet]
        public List<Model> Get()
        {
            return _modelService.Get();
        }
    }
}