using System;

namespace GymClassBooking.SpotMe.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Specialization { get; set; } // e.g., Yoga, Weights, Cardio
        public string Biography { get; set; }
        public string PhotoPath { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
    }
}