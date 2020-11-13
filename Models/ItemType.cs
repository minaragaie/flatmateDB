using System;
using System.ComponentModel.DataAnnotations;

namespace FlatmateDB.Models
{
    public class ItemType
    {
        [Key]
        public int ItemTypeId { get; set; }
        public string ItemTypeLabel { get; set; }
    }
}
