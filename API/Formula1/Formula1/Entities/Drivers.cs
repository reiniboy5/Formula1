using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Formula1.Entities
{
    public class Drivers
    {
        [Key]
        public int DriversID { get; set; }
        public string DriverName { get; set; }
        public string DiverSurname { get; set; }
        public int DriverNumber { get; set; }
        public string DriverImage { get; set; }
    }
}
