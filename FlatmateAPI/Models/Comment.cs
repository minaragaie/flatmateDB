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
        public Post Post { get; set; }
        [ForeignKey("Post")]
        public int? PostId { get; set; }
        public string Edited { get; set; }
        public string CreatedAt { get; set; }
        public House House { get; set; }
        [ForeignKey("House")]
        public int HouseId { get; set; }
        public User User { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }


    }
}