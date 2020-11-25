using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlatmateAPI.Models
{
    [Keyless]
    public class ListItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int ListId { get; set; }
        public List List { get; set; }
        public int Quanitiy { get; set; }
#nullable enable
        public string? Details { get; set; }
        [Required]
        public int ItemTypeId { get; set; }
        public bool HasBeenPurchased { get; set; }
        public string? PhotoURL { get; set; }
        public int StoreId { get; set; }
    }
}
