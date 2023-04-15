using Microsoft.AspNetCore.Mvc;
using MTIT.Transport.Services;

using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MTIT.Transport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportController : ControllerBase
    {
        private readonly ITransportService _transportService;

        public TransportController(ITransportService transportService)
        {
            _transportService = transportService ?? throw new ArgumentNullException(nameof(transportService));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_transportService.GetTransports());
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _transportService.GetTransport(id) != null ? Ok(_transportService.GetTransport(id)) : NoContent();
        }


        [HttpPost]
        public IActionResult Post([FromBody] Models.Transport transport)
        {
            return Ok(_transportService.AddTransport(transport));
        }


        [HttpPut]
        public IActionResult Put([FromBody] Models.Transport transport)
        {
            return Ok(_transportService.UpdateTransport(transport));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _transportService.DeleteTransport(id);

            return result.HasValue & result == true ? Ok($"Transport ID: {id} got deleted successfully.")
                : BadRequest($"Unable to delete the transport ID: {id}.");
        }
    }
}
