using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlatmateDB.Models
{
    public class UserHouse
    {
        [Key]
        public int HouseId { get; set; }
        public House House { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<User> Users { get; set; }
        public List<House> Houses { get; set; }

    }
}
