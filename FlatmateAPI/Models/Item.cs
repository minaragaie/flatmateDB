using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("Item")]
    public class Item
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(40), Required]
        public string Label { get; set; }
        public ItemType Type { get; set; }
        [ForeignKey("Type")]
        public int ItemTypeId { get; set; }
        public int Quanitiy { get; set; }
        public bool HasBeenPurchased { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime EditiedAt { get; set; }
        public House House { get; set; }
        [ForeignKey("House")]
        public int HouseId { get; set; }
#nullable enable
        public string? Details { get; set; }
        public List<Store>? Stores { get; set; }




    }
}
