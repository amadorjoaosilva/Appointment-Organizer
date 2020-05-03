using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myMicroservice
{
    public class Attendee
    {
        public int AttendeeId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string TelephoneNumber { get; set; }

        public List<Booking> Bookings { get; set; }
    }
}
