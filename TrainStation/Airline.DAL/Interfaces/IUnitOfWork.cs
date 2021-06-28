using TrainStation.DAL.Interfaces.IEntityRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainStation.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IPassengerRepository PassengerRepository { get; }
        IPassageScheduleRepository PassageScheduleRepository { get; }
        IPassageRepository PassageRepository { get; }
    }
}
