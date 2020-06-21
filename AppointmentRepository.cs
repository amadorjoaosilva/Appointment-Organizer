using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myMicroservice
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppointmentContext _context;
        public AppointmentRepository(AppointmentContext context)
        {
            _context = context;
        }

        public async Task<Attendee> GetAttendeeAsync(int id) 
        {
            var attendee = _context.Attendees.SingleOrDefaultAsync(a => a.AttendeeId == id);
            return await attendee;
        }

        public async Task<Attendee> Add(Attendee entity)
        {
            _context.Attendees.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Attendee> Update(Attendee attendee) 
        {
            //_context.Entry(Attendee).State = EntityState.Modified;
            _context.Attendees.Update(attendee);
            await _context.SaveChangesAsync();
            return attendee;
        }


        public async Task<Attendee> Delete(int id)
        {
            var attendeeToDelete = await _context.Attendees.FindAsync(id);
            if (attendeeToDelete == null) 
            {
                return attendeeToDelete;
            }

            _context.Remove(attendeeToDelete);
            await _context.SaveChangesAsync();

            return attendeeToDelete;
        }

    }
}
