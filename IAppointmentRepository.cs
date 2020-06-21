using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myMicroservice
{
    public interface IAppointmentRepository
    {
        Task<Attendee> GetAttendeeAsync(int id);

        Task<Attendee> Add(Attendee attendee);

        Task<Attendee> Update(Attendee attendee);

        Task<Attendee> Delete(int id);

    }
}
