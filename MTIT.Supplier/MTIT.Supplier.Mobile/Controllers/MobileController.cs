using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using MTIT.Supplier.Mobile.Data;
using MTIT.Supplier.Mobile.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MTIT.Supplier.Mobile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        private readonly IMobileService _mobileService;

        public MobileController(IMobileService mobileService)
        {
            _mobileService = mobileService ?? throw new ArgumentNullException(nameof(mobileService));
        }


        /// <summary>
        /// Get all mobile
        /// </summary>
        /// <returns>return the list of mobile</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_mobileService.GetMobile());
        }

        /// <summary>
        /// Get mobile by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the mobile with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _mobileService.GetMobile(id) != null ? Ok(_mobileService.GetMobile(id)) : NoContent();
        }

        /// <summary>
        /// Add Mobile
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns>Return the added mobile</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Mobile mobile)
        {
            return Ok(_mobileService.AddMobile(mobile));
        }

        /// <summary>
        /// Update the mobile
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns>Return the updated mobile</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Mobile mobile)
        {
            return Ok(_mobileService.UpdateMobile(mobile));
        }

        /// <summary>
        /// Delete the mobile with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _mobileService.DeleteMobile(id);

            return result.HasValue & result == true ? Ok($"mobile with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the mobile with ID:{id}.");
        }
    }
}