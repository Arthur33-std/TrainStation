using System;
using System.Collections.Generic;
using System.Text;

namespace TrainStation.BLL.DTOs
{
  public  class PassageDTO
    {
        public int Id { get; set; }
        public string Froms { get; set; }
        public string Wheres { get; set; }
        public string Passages { get; set; }
    }
}
