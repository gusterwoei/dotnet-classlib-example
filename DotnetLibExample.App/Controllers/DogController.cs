using DotnetLibExample.Lib.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotnetLibExample.App.Controllers.DogController
{
    [Route("dogs")]
    [ApiController]
    public class DogController(DogService myService) : ControllerBase
    {
        private readonly DogService _myService = myService;

        [HttpGet("breeds")]
        public async Task<IActionResult> Get()
        {
            var breeds = await _myService.GetBreeds();
            return Ok(breeds);
        }

        [HttpGet("subbreeds/{breed}")]
        public async Task<IActionResult> GetSubBreeds(string breed)
        {
            var subBreeds = await _myService.GetSubBreeds(breed);
            return Ok(subBreeds);
        }
    }
}