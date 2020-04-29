using Microsoft.AspNetCore.Mvc;

namespace FakeAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class FakeController
    {
        [HttpGet]
        public string Get()
        {
            // Anrop till Fake Repo
            return "Hi there";
        }
    }
}