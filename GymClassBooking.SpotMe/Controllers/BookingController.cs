using GymClassBooking.SpotMe.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GymClassBooking.SpotMe.Controllers
{
    public class BookingController
    {
        private SessionController sessionController = new SessionController();

        public List<Session> GetAvailableSessions()
        {
            var allSessions = sessionController.GetAllSessions();
            return allSessions.FindAll(s => !s.IsFull);
        }

        public bool BookClass(int memberId, int sessionId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                // Check if already booked
                string checkQuery = "SELECT COUNT(*) FROM Bookings WHERE MemberId = @MemberId AND SessionId = @SessionId AND Status = 'Confirmed'";
                // Execute check

                // If not booked, create booking
                string insertQuery = @"INSERT INTO Bookings (MemberId, SessionId, BookingDate, SessionDate, Status) 
                                       VALUES (@MemberId, @SessionId, @BookingDate, @SessionDate, 'Confirmed')";
                // Execute

                // Update booked count in Sessions
                string updateQuery = "UPDATE Sessions SET BookedCount = BookedCount + 1 WHERE Id = @SessionId";
                // Execute

                return true;
            }
        }

        public List<Booking> GetMemberBookings(int memberId)
        {
            var bookings = new List<Booking>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT b.*, s.Name as SessionName, m.Name as MemberName 
                                 FROM Bookings b 
                                 JOIN Sessions s ON b.SessionId = s.Id 
                                 JOIN Members m ON b.MemberId = m.Id 
                                 WHERE b.MemberId = @MemberId 
                                 ORDER BY b.SessionDate DESC";
                // Execute
            }
            return bookings;
        }

        public bool CancelBooking(int bookingId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                // Update booking status
                string updateBooking = "UPDATE Bookings SET Status = 'Cancelled' WHERE Id = @Id";
                // Execute

                // Decrease booked count in Sessions
                string updateSession = @"UPDATE Sessions SET BookedCount = BookedCount - 1 
                                         WHERE Id = (SELECT SessionId FROM Bookings WHERE Id = @Id)";
                // Execute

                return true;
            }
        }
    }
}