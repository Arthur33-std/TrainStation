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
    public class PassageRepository : GenericRepository<Passage>, IPassageRepository
    {
        public PassageRepository(TrainStationContext db)
            : base(db)
        {
        }


        public async Task<IEnumerable<Passage>> GetPassagesPassage(string Passages)
        {
            return await db.Passage.Where(e => e.Passages == Passages).ToListAsync();
        }
    }
}
