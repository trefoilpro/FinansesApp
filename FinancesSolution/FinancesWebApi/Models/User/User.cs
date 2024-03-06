﻿using System.ComponentModel.DataAnnotations;

namespace FinancesWebApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public bool EmailConfirmed { get; set; } = false;
        public required string Password { get; set; }
        public int? PhoneNumberId { get; set; } = null;
        public bool PhoneNumberConfirmed { get; set; } = false;
        public int NumberOfPasswordAttempts { get; set; } = 5;
        public required ICollection<UserRole> UserRoles { get; set; }
        public UserSettings UserSettings { get; set; }
        public UserPhoneNumber UserPhoneNumber { get; set; }
        public ICollection<Account> Accounts { get; set; } = new List<Account>();
    }
}