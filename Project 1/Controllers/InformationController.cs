using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_1.Services;

namespace Project_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        private readonly IInformationServices _informationServices;

        public InformationController(IInformationServices informationServices)
        {
            _informationServices = informationServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var information = await _informationServices.GetAll();
            return Ok(information);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetByIdAsync(byte id)
        {
            var information = await _informationServices.GetById(id);
            if (information == null)
                return NotFound();

            return Ok(information);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(byte id)
        {
            var information = await _informationServices.GetById(id); 
            if (information == null)
                return NotFound("No information was found ");
            _informationServices.update(information);
            return Ok(information);
        }
        [HttpDelete("id")]
        public async Task<IActionResult> DeleteAsync(byte id)
        {
            var information = await _informationServices.GetById(id);
            if (information == null)
                return NotFound("No information was found" );
            _informationServices.Delete(information);
            return Ok(information);
        }
    }
}
