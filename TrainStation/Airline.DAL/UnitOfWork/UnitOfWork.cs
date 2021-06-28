using TrainStation.DAL.Interfaces;
using TrainStation.DAL.Interfaces.IEntityRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainStation.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IPassengerRepository _passengerRepository;
        private readonly IPassageScheduleRepository _passageScheduleRepository;
        private readonly IPassageRepository _passageRepository;

        public UnitOfWork(
            IPassengerRepository passengerRepository,
            IPassageScheduleRepository passageScheduleRepository,
            IPassageRepository passageRepository
            )
           
        {
            _passengerRepository = passengerRepository;
            _passageScheduleRepository = passageScheduleRepository;
            _passageRepository = passageRepository;
        }

        public IPassengerRepository PassengerRepository
        {
            get
            {
                return _passengerRepository;
            }
        }

       

        public IPassageScheduleRepository PassageScheduleRepository
        {
            get
            {
                return _passageScheduleRepository;
            }
        }


        public IPassageRepository PassageRepository
        {
            get
            {
                return _passageRepository;
            }
        }
    }
    }
