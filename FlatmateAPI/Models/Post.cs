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
        #nullable enable
        public string? HasAttatchment { get; set; }
        public DateTime? EditedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("House")]
        public int HouseId { get; set; }
        //[ForeignKey("User")]
        public int UserId { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
