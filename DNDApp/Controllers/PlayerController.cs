using DNDApp.Common.Models;
using Microsoft.AspNetCore.Mvc;
using DNDApp.Processors;

namespace DNDApp.Controllers
{
    [Route("api/[controller]")]
    public class PlayerController : Controller
    {
        private readonly IPlayerProcessor _processor;

        public PlayerController(IPlayerProcessor processor)
        {
            _processor = processor;
        }

        [HttpGet("[action]")]
        public IActionResult GetPlayerById(int id)
        {
            var request = _processor.GetById(id);

            return Ok(request);
        }

        [HttpPost("[action]")]
        public IActionResult CreatePlayer(Player model)
        {
            if (model.Id.HasValue) return BadRequest("ID must be null.");

            var request = _processor.CreatePlayer(model);

            return Ok(request);
        }
    }
}