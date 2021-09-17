using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Formula1.Entities
{
    public class Meeting
    {
        [Key]
        public int MeetingID { get; set; }
        public DateTime DateOfMeeting { get; set; }
    }
}
