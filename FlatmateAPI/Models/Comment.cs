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
        [ForeignKey("Activity")]
        public int ActivityId { get; set; }
        public int PostId { get; set; }
        public Activity Activity { get; set; }

    }
}
