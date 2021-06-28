using TrainStation.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.BLL.Interfaces.IServices
{
   public interface IPassageService
    {
        Task<IEnumerable<PassageDTO>> GetAllPassageAsync();
        Task<PassageDTO> GetPassageAsync(int Id);
        Task UpdatePassageAsync(PassageDTO passageDTO);
        Task AddPassageAsync(PassageDTO passageDTO);
        Task DeletePassageAsync(PassageDTO passageDTO);
        Task<IEnumerable<PassageDTO>> GetPassagesPassage(string Passages);
    }
}
