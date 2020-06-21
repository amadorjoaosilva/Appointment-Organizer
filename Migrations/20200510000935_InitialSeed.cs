using Microsoft.EntityFrameworkCore.Migrations;

namespace myMicroservice.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attendees",
                columns: new[] { "AttendeeId", "Email", "FirstName", "LastName", "TelephoneNumber" },
                values: new object[] { 1, "johnsmith@google.com", "John", "Smith", "317-555-5555" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "AttendeeId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "AttendeeId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "AttendeeId",
                keyValue: 1);
        }
    }
}
