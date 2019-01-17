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

//        [HttpPost("[action]")]
//        public IActionResult CreatePlayer(Campaign model)
//        {
//            if (model.Id.HasValue) return BadRequest("ID must be null.");
//
//            var request = _processor.CreatePlayer(model);
//
//            return Ok(request);
        
    }
}