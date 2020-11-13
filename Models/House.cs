using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlatmateDB.Models
{
    public class House
    {
        [Key]
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public List<Activity> Activities { get; set; }
    }
}
