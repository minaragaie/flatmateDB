using System;
using System.ComponentModel.DataAnnotations;

namespace FlatmateDB.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Label { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

    }
}
