using System;
using System.ComponentModel.DataAnnotations;

namespace FlatmateDB
{
    public class User
    {
        [Key]
        public int ApiKey { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVerified { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime LastLoginAt { get; set; }
        public string PhotoURL { get; set; }
    }
}
