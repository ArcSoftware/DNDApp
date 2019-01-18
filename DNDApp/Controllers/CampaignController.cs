using DNDApp.Common.Models;
using DNDApp.Processors;
using Microsoft.AspNetCore.Mvc;

namespace DNDApp.Controllers
{
    [Route("api/[controller]")]
    public class CampaignController : Controller
    {
        private readonly ICampaignProcessor _processor;

        public CampaignController(ICampaignProcessor processor)
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
        public IActionResult CreateCampaign(Campaign model)
        {
            if (model.Id.HasValue) return BadRequest("ID must be null.");

            var request = _processor.CreateCampaign(model);

            return Ok(request);
        }

        [HttpPost("[action]")]
        public IActionResult AddPlayerToCampaign(int campaignId, int playerId)
        {
            var request = _processor.AddPlayerToCampaign(
                new Campaign(){Id = campaignId}, 
                new Player(){Id = playerId});

            return Ok(request);
        }
    }
}