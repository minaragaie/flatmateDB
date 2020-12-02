using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string ApiKey { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
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
        public List<UserHouse> Houses { get; set; }
        public List<Activity> Activities { get; set; }

    }
}
