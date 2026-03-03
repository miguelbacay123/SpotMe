using System;

namespace GymClassBooking.SpotMe.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; } // Room number or studio
        public int Capacity { get; set; }
        public int BookedCount { get; set; }
        public string Difficulty { get; set; } // Beginner, Intermediate, Advanced
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        // Helper property
        public int AvailableSpots => Capacity - BookedCount;
        public bool IsFull => BookedCount >= Capacity;
    }
}