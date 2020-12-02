using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("Activity")]
    public class Activity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("House")]
        public int HouseId { get; set; }
        [ForeignKey("ActivityType")]
        public int ActivityType { get; set; }
        public int Privilege { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }
        //public User User { get; set; }
        public List<GroceryList> Lists { get; set; }
        public List<Duty> Duties { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
