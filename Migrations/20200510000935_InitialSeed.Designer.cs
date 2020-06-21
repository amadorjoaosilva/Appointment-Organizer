﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myMicroservice;

namespace myMicroservice.Migrations
{
    [DbContext(typeof(AppointmentContext))]
    [Migration("20200510000935_InitialSeed")]
    partial class InitialSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("myMicroservice.Attendee", b =>
                {
                    b.Property<int>("AttendeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AttendeeId");

                    b.ToTable("Attendees");

                    b.HasData(
                        new
                        {
                            AttendeeId = 1,
                            Email = "johnsmith@google.com",
                            FirstName = "John",
                            LastName = "Smith",
                            TelephoneNumber = "317-555-5555"
                        });
                });

            modelBuilder.Entity("myMicroservice.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttendeeId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("AttendeeId");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            BookingId = 1,
                            AttendeeId = 1
                        },
                        new
                        {
                            BookingId = 2,
                            AttendeeId = 2
                        });
                });

            modelBuilder.Entity("myMicroservice.Booking", b =>
                {
                    b.HasOne("myMicroservice.Attendee", "Attendee")
                        .WithMany("Bookings")
                        .HasForeignKey("AttendeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}