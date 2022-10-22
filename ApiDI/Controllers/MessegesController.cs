using DIDemoLib;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessegesController : ControllerBase
    {
        private readonly IMesseges _messeges;

        public MessegesController(IMesseges messeges)
        {
            _messeges = messeges;
        }
        // GET: api/<MessegesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { _messeges.SayHello(), _messeges.SayGoodBye()};
        }
    }
}
