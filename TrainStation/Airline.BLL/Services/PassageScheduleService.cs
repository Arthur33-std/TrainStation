using TrainStation.BLL.DTOs;
using TrainStation.BLL.Interfaces.IServices;
using TrainStation.DAL.Entities;
using TrainStation.DAL.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.BLL.Services
{
    public class PassageScheduleService : SetOfFields, IPassageScheduleService
    {
        public PassageScheduleService(IUnitOfWork unitOfWork, IMapper mapper)
           : base(unitOfWork, mapper)
        {
        }

        public async Task AddPassageScheduleAsync(PassageScheduleDTO passageScheduleDTO)
        {
            var passageSchedule = mapper.Map<PassageSchedule>(passageScheduleDTO);

            await unitOfWork.PassageScheduleRepository.Add(passageSchedule);
        }

        public async Task DeletePassageScheduleAsync(PassageScheduleDTO passageScheduleDTO)
        {
            var passageSchedule = await unitOfWork.PassageScheduleRepository.Get(passageScheduleDTO.Id);

            if (passageSchedule == null)
            {
                throw new Exception("Not found");
            }



            await unitOfWork.PassageScheduleRepository.Delete(passageSchedule);
        }

        public async Task<PassageScheduleDTO> GetPassageScheduleAsync(int Id)
        {
            var passageSchedule = await unitOfWork.PassageScheduleRepository.Get(Id);

            if (passageSchedule == null)
            {
                throw new Exception("Not found");
            }

            return mapper.Map<PassageScheduleDTO>(passageSchedule);
        }



        public async Task<IEnumerable<PassageScheduleDTO>> GetAllPassageScheduleAsync()
        {
            var passageSchedule = await unitOfWork.PassageScheduleRepository.GetAll();

            if (passageSchedule == null)
            {
                throw new Exception("Not found");
            }

            return mapper.Map<IEnumerable<PassageScheduleDTO>>(passageSchedule);
        }

        public async Task<IEnumerable<PassageScheduleDTO>> GetDatePassageSchedule(string DepartureDate)
        {
            if (DepartureDate == null)
            {
                throw new Exception("is null");
            }

            var passageSchedule = await unitOfWork.PassageScheduleRepository.GetDatePassageSchedule(DepartureDate);

            if (passageSchedule == null)
            {
                throw new Exception("Not found");
            }

            return mapper.Map<IEnumerable<PassageScheduleDTO>>(passageSchedule);
        }

        public async Task UpdatePassageScheduleAsync(PassageScheduleDTO passageScheduleDTO)
        {
            var passageSchedule = mapper.Map<PassageSchedule>(passageScheduleDTO);

            await unitOfWork.PassageScheduleRepository.Update(passageSchedule);
        }


    }
}

