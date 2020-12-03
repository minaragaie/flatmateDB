using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(200)]
        public string Label { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public DateTime? Edited { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("House")]
        public int HouseId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }


    }
}