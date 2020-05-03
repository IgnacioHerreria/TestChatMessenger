using System.Collections.Generic;
using Services.Chat.Services;
using Microsoft.AspNetCore.Mvc;
using Utils.Chat.Dto;
using System.Linq;
using LoggerService;

namespace WebApi.Chat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MdlController : Controller
    {
        private readonly IModelService _modelService;
        private readonly ILoggerManager _loggerManager;

        public MdlController(IModelService modelService, ILoggerManager loggerManager)
        {
            _modelService = modelService;
            _loggerManager = loggerManager;
        }

        [HttpGet]
        public List<DtoResponse> Get()
        {
            _loggerManager.LogInfo("Here is info message from the controller.");
            _loggerManager.LogDebug("Here is debug message from the controller.");
            _loggerManager.LogWarn("Here is warn message from the controller.");
            _loggerManager.LogError("Here is error message from the controller.");
            return _modelService.Get()?.ToList();
        }
    }
}