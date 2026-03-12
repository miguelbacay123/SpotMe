using System;

namespace GymClassBooking.SpotMe.Models
{
    public class BookingClass
    {
        public int Id { get; set; }
        public string Category { get; set; } // Yoga, Pilates, etc.
        public string TrainerName { get; set; }
        public int TrainerId { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public int BookedCount { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; } // Upcoming, Ongoing, Completed, Cancelled
        public bool IsActive { get; set; }
        public int StaffId { get; set; }

        // Helper properties
        public int AvailableSpots => Capacity - BookedCount;
        public bool IsFull => BookedCount >= Capacity;
        public string Duration => (EndTime - StartTime).ToString(@"hh\:mm");
    }
}