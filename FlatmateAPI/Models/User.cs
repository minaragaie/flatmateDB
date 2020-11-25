using System;
using System.ComponentModel.DataAnnotations;

namespace FlatmateAPI.Models
{
    public class User
    {
        [Key]
        public int ApiKey { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required, MaxLength(60)]
        public string DisplayName { get; set; }
        [Required, MaxLength(60)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVerified { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime LastLoginAt { get; set; }
        public string PhotoURL { get; set; }
    }
}
