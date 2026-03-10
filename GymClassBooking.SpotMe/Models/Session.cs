using System;

namespace GymClassBooking.SpotMe.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string TrainerName { get; set; }
        public int TrainerId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration
        {
            get { return EndTime - StartTime; }
        }
        public int Capacity { get; set; }
        public int BookedCount { get; set; }
        public string Status { get; set; } // Upcoming, Ongoing, Completed, Cancelled
        public bool IsActive { get; set; }

        /// <summary>
        /// Calculates the current status based on current time
        /// </summary>
        public string GetCurrentStatus()
        {
            DateTime now = DateTime.Now;
            if (now < StartTime)
                return "Upcoming";
            else if (now >= StartTime && now <= EndTime)
                return "Ongoing";
            else if (now > EndTime)
                return "Completed";
            return "Upcoming";
        }
    }
}