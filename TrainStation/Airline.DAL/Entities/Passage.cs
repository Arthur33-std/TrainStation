using TrainStation.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace TrainStation.DAL.Entities
{
    public partial class Passage:IEntity
    {
        public int Id { get; set; }
        public int PassageSheduleId { get; set; }
        public int PassengerId { get; set; }
        public string Froms { get; set; }
        public string Wheres { get; set; }
        public string Passages { get; set; }
        
    }
}
