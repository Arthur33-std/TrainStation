using TrainStation.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.DAL.Interfaces.IEntityRepositories
{
    public interface IPassageRepository : IGenericRepository<Passage>
    {
        Task<IEnumerable<Passage>> GetPassagesPassage(string Passages);
    }
}
