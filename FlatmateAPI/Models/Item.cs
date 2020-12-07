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
        public string CreatedAt { get; set; }
        public string EditiedAt { get; set; }
        public User AddedBy { get; set; }
        [ForeignKey("AddedBy")]
        public string UserId { get; set; }
        public House House { get; set; }
        [ForeignKey("House")]
        public int? HouseId { get; set; }
        public GroceryList GroceryList { get; set; }
        [ForeignKey("GroceryList")]
        public int GroceryListId { get; set; }
#nullable enable
        public string? Details { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        public List<Store>? Stores { get; set; }




    }
}
