using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myMicroservice
{
    public class AppointmentContext : DbContext
    {
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Appointment;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendee>().HasData(
                new Attendee
                {
                    AttendeeId = 1,
                    FirstName = "John",
                    LastName = "Smith",
                    Email = "johnsmith@google.com",
                    TelephoneNumber = "317-555-5555"
                }
                );
            modelBuilder.Entity<Booking>().HasData(
                new Booking { BookingId = 1, AttendeeId = 1 },
                new Booking { BookingId = 2, AttendeeId = 1 }
                );

        }
    }
}
