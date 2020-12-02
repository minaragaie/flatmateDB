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
        [ForeignKey("Activity")]
        public int ActivityId { get; set; }
        //public Activity Activity { get; set; }
        public List<ListItem> Items { get; set; }

    }
}
