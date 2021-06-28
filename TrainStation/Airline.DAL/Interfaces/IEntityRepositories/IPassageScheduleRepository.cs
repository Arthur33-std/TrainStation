using TrainStation.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.DAL.Interfaces.IEntityRepositories
{
    public interface IPassageScheduleRepository : IGenericRepository<PassageSchedule>
    {
        Task<IEnumerable<PassageSchedule>> GetDatePassageSchedule(string DepartureDate);
    }
}
