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
    public class PassengerRepository : GenericRepository<Passenger>, IPassengerRepository
    {
        public PassengerRepository(TrainStationContext db)
            : base(db)
        {
        }

     
        public async Task<IEnumerable<Passenger>> GetNamePassengers(string Name)
        {
            return await db.Passenger.Where(e => e.Name == Name).ToListAsync();
        }
    }
}
