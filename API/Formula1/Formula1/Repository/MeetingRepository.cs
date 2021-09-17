using Formula1.Data;
using Formula1.Entities;
using Formula1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formula1.Repository
{
    public class MeetingRepository : IAppRepository<Meeting>
    {
        readonly Formula1DbContext formula1Db;

        public MeetingRepository(Formula1DbContext _formula1Db)
        {
            formula1Db = _formula1Db;
        }

        public void Add(Meeting meeting)
        {
            formula1Db.Meeting.Add(meeting);
            formula1Db.SaveChanges();
        }

        public void Delete(Meeting meeting)
        {
            formula1Db.Meeting.Remove(meeting);
            formula1Db.SaveChanges();
        }

        public Meeting Get(long id)
        {
            return formula1Db.Meeting.FirstOrDefault(x => x.MeetingID == id);
        }

        public IEnumerable<Meeting> GetAll()
        {
            return formula1Db.Meeting.ToList();
        }

        public void Update(Meeting meeting, Meeting entity)
        {
            meeting.DateOfMeeting = entity.DateOfMeeting;
            formula1Db.SaveChanges();
        }
    }
}
