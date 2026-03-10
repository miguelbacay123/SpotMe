using System;
using System.Collections.Generic;
using GymClassBooking.SpotMe.Models;

namespace GymClassBooking.SpotMe.Controllers
{
    public class DonationController
    {
        private List<Donation> donations = new List<Donation>();

        public DonationController()
        {
            InitializeFakeData();
        }

        private void InitializeFakeData()
        {
            donations = new List<Donation>
            {
                new Donation
                {
                    Id = 1,
                    Title = "New Gym Equipment",
                    Description = "Help us purchase new state-of-the-art gym equipment including treadmills, dumbbells, and weight machines.",
                    GoalAmount = 50000,
                    CurrentAmount = 34500,
                    Category = "Equipment",
                    CreatedDate = DateTime.Now.AddMonths(-2),
                    IsActive = true
                },
                new Donation
                {
                    Id = 2,
                    Title = "Expand Training Classes",
                    Description = "Support our mission to bring more fitness classes to the community. Help us hire additional trainers.",
                    GoalAmount = 30000,
                    CurrentAmount = 21000,
                    Category = "Training",
                    CreatedDate = DateTime.Now.AddMonths(-1),
                    IsActive = true
                },
                new Donation
                {
                    Id = 3,
                    Title = "Community Wellness Program",
                    Description = "Free fitness programs for underprivileged members of our community.",
                    GoalAmount = 20000,
                    CurrentAmount = 18500,
                    Category = "Community",
                    CreatedDate = DateTime.Now.AddDays(-20),
                    IsActive = true
                }
            };
        }

        public List<Donation> GetAllDonations()
        {
            return donations;
        }

        public Donation GetDonationById(int id)
        {
            return donations.Find(d => d.Id == id);
        }

        public void AddDonation(Donation donation)
        {
            donation.Id = donations.Count + 1;
            donation.CreatedDate = DateTime.Now;
            donations.Add(donation);
        }

        public void UpdateDonation(Donation donation)
        {
            var existing = donations.Find(d => d.Id == donation.Id);
            if (existing != null)
            {
                existing.Title = donation.Title;
                existing.Description = donation.Description;
                existing.GoalAmount = donation.GoalAmount;
                existing.CurrentAmount = donation.CurrentAmount;
                existing.Category = donation.Category;
                existing.IsActive = donation.IsActive;
            }
        }

        public void DeleteDonation(int id)
        {
            donations.RemoveAll(d => d.Id == id);
        }
    }
}