using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formula1.Dtos
{
    public class MeetingDto
    {
        public int MeetingID { get; set; }
        public DateTime DateOfMeeting { get; set; }
        public DateTime TimeOfMeeting { get; set; }
    }
}
