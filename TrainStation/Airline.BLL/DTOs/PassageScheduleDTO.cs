using System;
using System.Collections.Generic;
using System.Text;

namespace TrainStation.BLL.DTOs
{
   public class PassageScheduleDTO
    {
        public int Id { get; set; }
        public string DepartureDate { get; set; }
        public string DepartureTime { get; set; }
    }
}
