using System;
using System.ComponentModel.DataAnnotations;

namespace FlatmateDB.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public int Quanitiy { get; set; }
        public string Label { get; set; }
#nullable enable
        public string? Details { get; set; }
        public int ItemTypeId { get; set; }
    }
}
