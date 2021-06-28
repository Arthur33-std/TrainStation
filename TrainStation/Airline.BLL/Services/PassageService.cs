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
    public class PassageService : SetOfFields, IPassageService
    {
        public PassageService(IUnitOfWork unitOfWork, IMapper mapper)
           : base(unitOfWork, mapper)
        {
        }

        public async Task AddPassageAsync(PassageDTO passageDTO)
        {
            var passage = mapper.Map<Passage>(passageDTO);

            await unitOfWork.PassageRepository.Add(passage);
        }

        public async Task DeletePassageAsync(PassageDTO passageDTO)
        {
            var passage = await unitOfWork.PassageRepository.Get(passageDTO.Id);

            if (passage == null)
            {
                throw new Exception("Not found");
            }



            await unitOfWork.PassageRepository.Delete(passage);
        }

        public async Task<PassageDTO> GetPassageAsync(int Id)
        {
            var passage = await unitOfWork.PassageRepository.Get(Id);

            if (passage == null)
            {
                throw new Exception("Not found");
            }

            return mapper.Map<PassageDTO>(passage);
        }



        public async Task<IEnumerable<PassageDTO>> GetAllPassageAsync()
        {
            var passages = await unitOfWork.PassageRepository.GetAll();

            if (passages == null)
            {
                throw new Exception("Not found");
            }

            return mapper.Map<IEnumerable<PassageDTO>>(passages);
        }

        public async Task<IEnumerable<PassageDTO>> GetPassagesPassage(string Passages)
        {
            if (Passages == null)
            {
                throw new Exception("is null");
            }

            var passage = await unitOfWork.PassageRepository.GetPassagesPassage(Passages);

            if (passage == null)
            {
                throw new Exception("Not found");
            }

            return mapper.Map<IEnumerable<PassageDTO>>(passage);
        }

        public async Task UpdatePassageAsync(PassageDTO passageDTO)
        {
            var passage = mapper.Map<Passage>(passageDTO);

            await unitOfWork.PassageRepository.Update(passage);
        }


    }



}


