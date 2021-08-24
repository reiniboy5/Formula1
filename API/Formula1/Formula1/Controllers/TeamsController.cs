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
    [Route("api/Teams")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly IAppRepository<Teams> _appRepository;

        public TeamsController(IAppRepository<Teams> appRepository)
        {
            _appRepository = appRepository;
        }

        // GET: api/Teams
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Teams> teams = _appRepository.GetAll();

            return Ok(teams);
        }

        // GET: api/Teams/{id}

        [HttpGet("{id}", Name = "GetTeams")]
        public IActionResult Get(long id)
        {
            Teams team = _appRepository.Get(id);


            if (team == null)
            {
                return NotFound("Requested Team does not exist.");
            }

            return Ok(team);
        }

        // GET: api/Teams
        [HttpPost]
        public IActionResult Post([FromBody] Teams team)
        {
            if (team == null)
            {
                return BadRequest("Team is null.");
            }
            _appRepository.Add(team);
            return CreatedAtRoute(
                  "GetTeams",
                  new { Id = team.TeamID },
                  team);
        }

        // PUT: api/Teams/{5}
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Teams team)
        {
            if (team == null)
            {
                return BadRequest("Team is null.");
            }

            Teams teamToUpdate = _appRepository.Get(id);
            if (teamToUpdate == null)
            {
                return NotFound("The Team does not exist.");
            }
            _appRepository.Update(teamToUpdate, team);

            return NoContent();
        }


        // DELETE: api/Teams/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Teams team = _appRepository.Get(id);
            if (team == null)
            {
                return NotFound("The Team does not exist.");
            }
            _appRepository.Delete(team);

            return NoContent();
        }
    }
}
