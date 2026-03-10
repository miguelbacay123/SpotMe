using System;

namespace GymClassBooking.SpotMe.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal GoalAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public string Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public decimal PercentageRaised
        {
            get
            {
                if (GoalAmount == 0) return 0;
                return (CurrentAmount / GoalAmount) * 100;
            }
        }
    }
}