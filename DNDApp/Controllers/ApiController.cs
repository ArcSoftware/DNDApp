using DNDApp.Common.Interfaces;
using DNDApp.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DNDApp.Controllers
{
    [Route("api/[controller]")]
    public class ApiController : Controller
    {
        private readonly IRepository _repo;

        public ApiController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("[action]")]
        public IActionResult Get()
        {
            //TODO: Build out processors to remove direct repo access to controller. 
            return Ok(_repo.GetItems<PlayerEntity>(p => true).FirstOrDefault());

        }
    }
}