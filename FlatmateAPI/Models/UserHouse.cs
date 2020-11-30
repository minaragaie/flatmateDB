using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("UserHouse")]
    public class UserHouse
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("User")]
        public int InvitedUserId { get; set; }
        public bool Accepted { get; set; }
        [ForeignKey("House")]
        public int HouseId { get; set; }
        public House House { get; set; }
        public User User { get; set; }
        [ForeignKey("Activity")]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
    }
}
