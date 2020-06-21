using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myMicroservice.Models
{
    public class AttendeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string TelephoneNumber { get; set; }

        public List<BookingModel> Bookings { get; set; }

    }
}
