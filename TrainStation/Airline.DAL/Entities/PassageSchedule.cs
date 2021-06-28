using TrainStation.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace TrainStation.DAL.Entities
{
    public partial class PassageSchedule : IEntity
    {  
        public int Id { set; get; }
        public string DepartureDate { get; set; }
        public string DepartureTime { get; set; }

       
    }
}
