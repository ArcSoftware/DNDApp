using DNDApp.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DNDApp.Common.Models;
using DNDApp.Processors;

namespace DNDApp.Controllers
{
    [Route("api/[controller]")]
    public class ApiController : Controller
    {
        private readonly IRepository _repo;
        private readonly IProcessorFactory _processorFactory;

        public ApiController(IRepository repo, IProcessorFactory processorFactory)
        {
            _repo = repo;
            _processorFactory = processorFactory;
        }

        [HttpGet("[action]")]
        public IActionResult Get<TModel>(TModel model) where TModel : DNDObjectBase
        {
            var processor = _processorFactory.GetProcessor<TModel>(model);

            var request = processor.GetById(model);

            return Ok(request.Item);
        }
    }
}