using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    public class Activity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int HouseId { get; set; }
        public int ActivityType { get; set; }
        public int Privilege { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
