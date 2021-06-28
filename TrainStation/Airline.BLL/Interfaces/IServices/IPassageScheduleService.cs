using TrainStation.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.BLL.Interfaces.IServices
{
    public interface IPassageScheduleService
    {
        Task<IEnumerable<PassageScheduleDTO>> GetAllPassageScheduleAsync();
        Task<PassageScheduleDTO> GetPassageScheduleAsync(int Id);
        Task UpdatePassageScheduleAsync(PassageScheduleDTO passageScheduleDTO);
        Task AddPassageScheduleAsync(PassageScheduleDTO passageScheduleDTO);
        Task DeletePassageScheduleAsync(PassageScheduleDTO passageScheduleDTO);
        Task<IEnumerable<PassageScheduleDTO>> GetDatePassageSchedule(string DepartureDate);

    }
}
