using System;

namespace GymClassBooking.SpotMe.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public int SessionId { get; set; }
        public string SessionName { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime SessionDate { get; set; }
        public string Status { get; set; } // Confirmed, Cancelled, Completed
        public string Notes { get; set; }
    }
}