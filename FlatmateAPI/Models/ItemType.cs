using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    public enum ItemTypeLabel 
    {
        [Description("Baby")]
        Baby = 1,
        [Description("Bakery")]
        Bakery = 2,
        [Description("Beverages")]
        Beverages = 3,
        [Description("Breakfast")]
        Breakfast = 4,
        [Description("Condiments")]
        Condiments = 5,
        [Description("Cooking")]
        Cooking = 6,
        [Description("Dairy")]
        Dairy = 7,
        [Description("Deli")]
        Deli = 8,
        [Description("Frozen")]
        Frozen = 9,
        [Description("Grains")]
        Grains = 10,
        [Description("Health")]
        Health = 11,
        [Description("Household")]
        Household = 12,
        [Description("Meat")]
        Meat = 13,
        [Description("Pet")]
        Pet = 14,
        [Description("Produce")]
        Produce = 15,
        [Description("Seafood")]
        Seafood = 16,
        [Description("Snacks")]
        Snacks = 17,
        [Description("Wine")]
        Wine = 18,
        [Description("Other")]
        Other = 19
    }

    [Table("ItemType")]
    public class ItemType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(40)]
        public string Label { get; set; }
        public List<Item> Items { get; set; }
    }
}
