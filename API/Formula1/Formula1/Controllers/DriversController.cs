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
    [Route("api/Drivers")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IAppRepository<Drivers> _appRepository;

        public DriversController(IAppRepository<Drivers> appRepository)
        {
            _appRepository = appRepository;
        }

        // GET: api/Drivers
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Drivers> drivers = _appRepository.GetAll();

            return Ok(drivers);
        }

        // GET: api/Drivers/{id}

        [HttpGet("{id}", Name = "GetDrivers")]
        public IActionResult Get(long id)
        {
            Drivers driver = _appRepository.Get(id);


            if (driver == null)
            {
                return NotFound("Requested Drivers does not exist.");
            }

            return Ok(driver);
        }

        // GET: api/Drivers
        [HttpPost]
        public IActionResult Post([FromBody] Drivers driver)
        {
            if (driver == null)
            {
                return BadRequest("Drivers is null.");
            }
            _appRepository.Add(driver);
            return CreatedAtRoute(
                  "GetDrivers",
                  new { Id = driver.DriversID },
                  driver);
        }

        // PUT: api/Drivers/{5}
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Drivers driver)
        {
            if (driver == null)
            {
                return BadRequest("Drivers is null.");
            }

            Drivers driverToUpdate = _appRepository.Get(id);
            if (driverToUpdate == null)
            {
                return NotFound("The Drivers does not exist.");
            }
            _appRepository.Update(driverToUpdate, driver);

            return NoContent();
        }


        // DELETE: api/Drivers/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Drivers driver = _appRepository.Get(id);
            if (driver == null)
            {
                return NotFound("The Drivers does not exist.");
            }
            _appRepository.Delete(driver);

            return NoContent();
        }
    }
}
