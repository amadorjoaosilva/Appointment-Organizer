using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using myMicroservice.Models;

namespace myMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeeController : ControllerBase
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMapper _mapper; 

        public AttendeeController(IAppointmentRepository appointmentRepository, IMapper mapper) 
        {
            _appointmentRepository = appointmentRepository;
            _mapper = mapper;
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<AttendeeModel> Get(int id) 
        {
            var result = await _appointmentRepository.GetAttendeeAsync(id);

            var attendeeModel = _mapper.Map<AttendeeModel>(result);

            return attendeeModel;
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<Attendee>> Post(Attendee attendee) 
        {
            await _appointmentRepository.Add(attendee);
            return CreatedAtAction("Get", new { id = attendee.AttendeeId }, attendee);
        }


        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Attendee attendee) 
        { 
            if(id != attendee.AttendeeId) 
            {
                return BadRequest();
            }
            await _appointmentRepository.Update(attendee);
            return NoContent();
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var attendeeToDelete = await _appointmentRepository.Delete(id);
            if (attendeeToDelete == null)
            {
                return NotFound();
            }
            return NoContent();
        }

    }
}