using System.Threading.Tasks;
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

            return Ok(request.Item);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddPlayerAsync(Player model)
        {
            var request = await _processor.CreatePlayer(model);

            return Ok(request.Item);
        }
    }
}