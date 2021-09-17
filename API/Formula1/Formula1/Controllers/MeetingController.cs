using Formula1.Entities;
using Formula1.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formula1.Controllers
{
    [Route("api/Meeting")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        private readonly IAppRepository<Meeting> _appRepository;

        public MeetingController(IAppRepository<Meeting> appRepository)
        {
            _appRepository = appRepository;
        }

        // GET: api/Meeting
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Meeting> meetings = _appRepository.GetAll();

            return Ok(meetings);
        }

        // GET: api/Meeting/{id}

        [HttpGet("{id}", Name = "GetMeeting")]
        public IActionResult Get(long id)
        {
            Meeting meeting = _appRepository.Get(id);


            if (meeting == null)
            {
                return NotFound("Requested Meeting does not exist.");
            }

            return Ok(meeting);
        }

        // GET: api/Meeting
        [HttpPost]
        public IActionResult Post([FromBody] Meeting meeting)
        {
            if (meeting == null)
            {
                return BadRequest("Meeting is null.");
            }
            _appRepository.Add(meeting);
            return CreatedAtRoute(
                  "GetMeeting",
                  new { Id = meeting.MeetingID },
                  meeting);
        }

        // PUT: api/Meeting/{5}
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Meeting meeting)
        {
            if (meeting == null)
            {
                return BadRequest("Meeting is null.");
            }

            Meeting meetingToUpdate = _appRepository.Get(id);
            if (meetingToUpdate == null)
            {
                return NotFound("The Meeting does not exist.");
            }
            _appRepository.Update(meetingToUpdate, meeting);

            return NoContent();
        }


        // DELETE: api/Meeting/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Meeting meeting = _appRepository.Get(id);
            if (meeting == null)
            {
                return NotFound("The Meeting does not exist.");
            }
            _appRepository.Delete(meeting);

            return NoContent();
        }
    }
}
