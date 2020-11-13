using System;
using Microsoft.EntityFrameworkCore;

namespace FlatmateDB.Models
{
    [Keyless]
    public class ListItem
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int ListId { get; set; }
        public List List { get; set; }
    }
}
