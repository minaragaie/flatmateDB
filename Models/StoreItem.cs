using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateDB.Models
{
    public class StoreItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public List<Item> Items { get; set; }
        public List<Store> Stores { get; set; }

    }
}
