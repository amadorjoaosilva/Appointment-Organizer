using AutoMapper;
using myMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myMicroservice
{
    public class AttendeeProfile : Profile
    {
        public AttendeeProfile() 
        {
            this.CreateMap<Attendee, AttendeeModel>()
                .ForMember(viewModel => viewModel.Bookings, conf => conf.MapFrom(value => value.Bookings))
                .ReverseMap();

            this.CreateMap<Booking, BookingModel>()
                .ForMember(bookModel => bookModel.Attendee, conf =>conf.MapFrom(value => value.Attendee))
                .ReverseMap();
        }
    }
}
