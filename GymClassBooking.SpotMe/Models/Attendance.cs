using System;

namespace GymClassBooking.SpotMe.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public int BookingClassId { get; set; }
        public string ClassName { get; set; }
        public DateTime? CheckInTime { get; set; }
        public DateTime ClassDate { get; set; }
        public string Status { get; set; } // Present, Absent, Late
    }
}