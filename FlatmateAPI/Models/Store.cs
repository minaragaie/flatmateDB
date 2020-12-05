using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("Store")]
    public class Store
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(40)]
        public string Label { get; set; }
        [Required, MaxLength(200)]
        public string Location { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Price { get; set; }
        public List<Item> Items { get; set; }

    }
}