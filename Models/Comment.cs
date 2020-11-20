using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateDB.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Label { get; set; }
        public int ActivityId { get; set; }
        public int PostId { get; set; }
        public Activity Activity { get; set; }

    }
}
