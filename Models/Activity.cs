using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlatmateDB.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int HouseId { get; set; }
        public int ActivityType { get; set; }
        public int Privilege { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
