using System.Linq;
using FakeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FakeAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class FakeController : ControllerBase
    {
        private readonly FakeContext _context;

        public FakeController(FakeContext context)
        {
            _context = context;
        }
        [HttpGet]
        public string Get()
        {
            return _context.Fakes.FirstOrDefault().Name;
             
            // Anrop till Fake Repo
            // return "Hello good sir";
        }
    }
}