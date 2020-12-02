using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlatmateAPI.Models
{
    [Table("ListItem")]
    public class ListItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [ForeignKey("Item")]
        public int? ItemId { get; set; }
        public Item Item { get; set; }
        [ForeignKey("List")]
        public int? ListId { get; set; }
        //public List List { get; set; }
        public int Quanitiy { get; set; }
        [ForeignKey("Activity")]
        public int? ActivityId { get; set; }
        public Activity Activity { get; set; }
        [ForeignKey("ItemType"), Required]
        public int? ItemTypeId { get; set; }
        [Required]
        public bool HasBeenPurchased { get; set; }
#nullable enable
        public string? Details { get; set; }
        public string? PhotoURL { get; set; }
        [ForeignKey("Store")]
        public int? StoreId { get; set; }
        
    }
}
