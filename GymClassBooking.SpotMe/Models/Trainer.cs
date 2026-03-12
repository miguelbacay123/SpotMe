using System;
using System.Collections.Generic;
using System.Drawing;

namespace GymClassBooking.SpotMe.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public List<string> Specializations { get; set; } = new List<string>();
        public string PhotoPath { get; set; }
        public Image Photo { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
    }
}