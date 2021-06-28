using TrainStation.DAL.DBContext;
using TrainStation.DAL.Entities;
using TrainStation.DAL.Interfaces.IEntityRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.DAL.Repositories.EntityRepositories
{

    public class PassageScheduleRepository : GenericRepository<PassageSchedule>, IPassageScheduleRepository
    {
        public PassageScheduleRepository(TrainStationContext db)
            : base(db)
        {
        }


        public async Task<IEnumerable<PassageSchedule>> GetDatePassageSchedule(string DepartureDate)
        {
            return await db.PassageSchedule.Where(e => e.DepartureDate == DepartureDate).ToListAsync();
        }
    }
}

