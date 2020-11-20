using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateDB.Models
{
    public class House
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public List<Activity> Activities { get; set; }
    }
}
