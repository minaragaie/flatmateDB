using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("Post")]
    public class Post
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required, MaxLength(200)]
        public string Label { get; set; }
        public DateTime? EditedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public House House { get; set; }
        [ForeignKey("House")]
        public int HouseId { get; set; }
        public User User { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
#nullable enable
        public List<Comment>? Comments { get; set; }
        public string? HasAttatchment { get; set; }
        
    }
}
