using System;

namespace GymClassBooking.SpotMe.Models
{
    public class SessionBooking
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; } // Active, Cancelled
    }
}