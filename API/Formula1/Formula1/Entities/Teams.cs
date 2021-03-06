using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Formula1.Entities
{
    public class Teams
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string TeamBase { get; set; }
        public string TeamChief { get; set; }
        public string TeamChassis { get; set; }
        public string TeamPowerUnit { get; set; }
        public int TeamWorldChampionships { get; set; }
        public int TeamPolePositions { get; set; }
        public int TeamFastestLaps { get; set; }
    }
}
