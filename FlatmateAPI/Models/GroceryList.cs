using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("GroceryList")]
    public class GroceryList
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required, MaxLength(40)]
        public string Label { get; set; }
        public string CreatedAt { get; set; }
        public string EditedAt { get; set; }
        public House House { get; set; }
        [ForeignKey("House")]
        public int HouseId { get; set; }
        public User ListCreator { get; set; }
        [ForeignKey("ListCreator")]
        public string UserId { get; set; }
        public int Privilige { get; set; }
        public bool IsStarred { get; set; }
        public List<Item> Items { get; set; }
    }
}
