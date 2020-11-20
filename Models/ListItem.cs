using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlatmateDB.Models
{
    [Keyless]
    public class ListItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int ListId { get; set; }
        public List List { get; set; }
    }
}
