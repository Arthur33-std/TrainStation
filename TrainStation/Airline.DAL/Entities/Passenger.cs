using TrainStation.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace TrainStation.DAL.Entities
{
    public partial class Passenger : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
