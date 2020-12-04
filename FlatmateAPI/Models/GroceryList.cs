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
        public int Label { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? EditedAt { get; set; }
        [ForeignKey("House")]
        public int HouseId { get; set; }
        public int UserId { get; set; }
        public int Privilige { get; set; }
        public bool IsStarred { get; set; }
        public List<ListItem> Items { get; set; }
    }
}
