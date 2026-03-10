using System;

namespace GymClassBooking.SpotMe.Models
{
    public class ActivityLog
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public string Category { get; set; }
        public string Icon { get; set; }
        public int? UserId { get; set; }

        public string TimeAgo
        {
            get
            {
                TimeSpan span = DateTime.Now - Timestamp;
                if (span.TotalSeconds < 60) return "just now";
                if (span.TotalMinutes < 60) return $"{(int)span.TotalMinutes}m ago";
                if (span.TotalHours < 24) return $"{(int)span.TotalHours}h ago";
                if (span.TotalDays < 7) return $"{(int)span.TotalDays}d ago";
                if (span.TotalDays < 30) return $"{(int)(span.TotalDays / 7)}w ago";
                return $"{(int)(span.TotalDays / 30)}mo ago";
            }
        }
    }
}