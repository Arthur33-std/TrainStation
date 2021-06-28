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
    public class PassageScheduleController : ControllerBase
    {
        private readonly IPassageScheduleService passageScheduleService;

        public PassageScheduleController(IPassageScheduleService passageScheduleService)
        {
            this.passageScheduleService = passageScheduleService;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PassageScheduleService>>> GetAll()
        {
            IEnumerable<PassageScheduleDTO> passageScheduleDto = await passageScheduleService.GetAllPassageScheduleAsync();

            if (passageScheduleDto == null)
            {
                return NotFound();
            }

            return Ok(passageScheduleDto);
        }
        
        [Route("{Id}")]
        [HttpGet]
        public async Task<ActionResult<PassageScheduleDTO>> GetPassageScheduleAsync(int Id)
        {
            PassageScheduleDTO passageScheduleDto = await passageScheduleService.GetPassageScheduleAsync(Id);

            if (passageScheduleDto == null)
            {
                return NotFound();
            }

            return Ok(passageScheduleDto);
        }
       
        [HttpPost]
        public async Task<ActionResult<PassageScheduleDTO>> Add([FromBody] PassageScheduleDTO passageScheduleDto)
        {
            if (passageScheduleDto == null)
            {
                return BadRequest();
            }

            await passageScheduleService.AddPassageScheduleAsync(passageScheduleDto);

            return Ok(passageScheduleDto);
        }
        /// <summary>
        /// Delete by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete("{Id}")]
        public async Task<ActionResult<PassageScheduleDTO>> Delete(int Id)
        {
            PassageScheduleDTO passageScheduleDto = await passageScheduleService.GetPassageScheduleAsync(Id);

            if (passageScheduleDto == null)
            {
                return NotFound();
            }

            await passageScheduleService.DeletePassageScheduleAsync(passageScheduleDto);
            return NoContent();
        }
 
        [HttpPut("{Id}")]
        public async Task<ActionResult<PassageScheduleDTO>> Update(int Id, [FromBody] PassageScheduleDTO passageScheduleDto)
        {


            if (passageScheduleDto == null)
            {
                return NotFound();
            }

            passageScheduleDto.Id = Id;

            await passageScheduleService.UpdatePassageScheduleAsync(passageScheduleDto);
            return Ok(passageScheduleDto);
        }
    }
}
