﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("Activity")]
    public class Activity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("House")]
        public int HouseId { get; set; }
        [ForeignKey("ActivityType")]
        public int ActivityType { get; set; }
        public int Privilege { get; set; }
        public DateTime CreatedAt { get; set; }
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
