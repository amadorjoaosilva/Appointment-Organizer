using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myMicroservice.Models
{
    public class BookingModel
    {
        public int BookingId { get; set; }

        public int AttendeeId { get; set; }

        public AttendeeModel Attendee { get; set; }
    }
}
