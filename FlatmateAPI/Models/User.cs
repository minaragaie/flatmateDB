using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("User")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ApiKey { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required, MaxLength(60)]
        public string DisplayName { get; set; }
        [Required, MaxLength(60)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVerified { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public string PhotoURL { get; set; }
        public List<House> Houses { get; set; }
        public List<House> OwnedHouses { get; set; }
    }
}
