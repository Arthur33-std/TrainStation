using TrainStation.BLL.DTOs;
using TrainStation.BLL.Interfaces.IServices;
using TrainStation.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainStation.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PassageController : ControllerBase
    {
        private readonly IPassageService passageService;

        public PassageController(IPassageService passageService)
        {
            this.passageService = passageService;
        }
       

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PassageService>>> GetAll()
        {
            IEnumerable<PassageDTO> passageDto = await passageService.GetAllPassageAsync();

            if (passageDto == null)
            {
                return NotFound();
            }

            return Ok(passageDto);
        }
      

        [Route("{Id}")]
        [HttpGet]
        public async Task<ActionResult<PassageDTO>> GetPassageAsync(int Id)
        {
            PassageDTO passageDto = await passageService.GetPassageAsync(Id);

            if (passageDto == null)
            {
                return NotFound();
            }

            return Ok(passageDto);
        }
       
        [HttpPost]
        public async Task<ActionResult<PassageDTO>> Add([FromBody]PassageDTO passageDto)
        {
            if (passageDto == null)
            {
                return BadRequest();
            }

            await passageService.AddPassageAsync(passageDto);

            return Ok(passageDto);
        }
        
        [HttpDelete("{Id}")]
        public async Task<ActionResult<PassageDTO>> Delete(int Id)
        {
            PassageDTO passageDto = await passageService.GetPassageAsync(Id);

            if (passageDto == null)
            {
                return NotFound();
            }

            await passageService.DeletePassageAsync(passageDto);
            return NoContent();
        }
        
        [HttpPut("{Id}")]
        public async Task<ActionResult<PassageDTO>> Update(int Id, [FromBody]PassageDTO passageDto)
        {


            if (passageDto == null)
            {
                return NotFound();
            }

            passageDto.Id = Id;

            await passageService.UpdatePassageAsync(passageDto);
            return Ok(passageDto);
        }
    }
}
