using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateDB.Models
{
    public class UserHouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public int HouseId { get; set; }
        public House House { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<User> Users { get; set; }
        public List<House> Houses { get; set; }

    }
}
