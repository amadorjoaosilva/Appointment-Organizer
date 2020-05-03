namespace myMicroservice
{
    public class Booking
    {
        public int BookingId { get; set; }

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    }
}