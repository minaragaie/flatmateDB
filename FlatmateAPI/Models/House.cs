using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("House")]
    public class House
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int OwnerId { get; set; }
        [MaxLength(200)]
        public string Location { get; set; }
        [MaxLength(40), Required]
        public string Name { get; set; }
        public List<UserHouse> Users { get; set; }
        public List<Activity> Activities { get; set; }
    }
}
