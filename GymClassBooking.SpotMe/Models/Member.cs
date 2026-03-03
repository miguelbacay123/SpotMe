using System;
using System.Drawing;

namespace GymClassBooking.SpotMe.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public Image Photo { get; set; }           // For runtime display
        public string PhotoPath { get; set; }      // For database storage
        public DateTime DateJoined { get; set; }
        public bool IsActive { get; set; }
    }
}