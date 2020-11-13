using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlatmateDB.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Label { get; set; }
        public int ActivityId { get; set; }
    }
}
