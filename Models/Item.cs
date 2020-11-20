using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateDB.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Quanitiy { get; set; }
        public string Label { get; set; }
#nullable enable
        public string? Details { get; set; }
        [Required]
        public int ItemTypeId { get; set; }

        public bool HasBeenPurchased { get; set; }
    }
}
