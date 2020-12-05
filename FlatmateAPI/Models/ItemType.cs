using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    public enum ItemTypeLabel 
    {
        Baby,
        Bakery,
        Beverages,
        Breakfast,
        Condiments,
        Cooking,
        Dairy,
        Deli,
        Frozen,
        Grains,
        Health,
        Household,
        Meat,
        Pet,
        Produce,
        Seafood,
        Snacks,
        Wine,
        Other
    }

    [Table("ItemType")]
    public class ItemType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(40)]
        public ItemTypeLabel Label { get; set; }
        public List<Item> Items { get; set; }
    }
}
