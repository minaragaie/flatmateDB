using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlatmateDB.Models
{
    public class List
    {
        [Key]
        public int Id { get; set; }
        public int ListType { get; set; }
        public int ActivityId { get; set; }
        public List<Item> Items { get; set; }

    }
}
