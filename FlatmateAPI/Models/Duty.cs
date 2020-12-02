using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("Duty")]
    public class Duty
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(40)]
        public string Label { get; set; }
        [ForeignKey("DutyType")]
        public int DutyTypeId { get; set; }
        [ForeignKey("User")]
        public int AssignedTo { get; set; }
        [ForeignKey("Activity")]
        public int ActivityId { get; set; }
        public DateTime DueDate { get; set; }
        public Activity Activity { get; set; }
        public bool OnProcess { get; set; }
        public bool Repeat { get; set; }
#nullable enable
        [MaxLength(200)]
        public string? Notes { get; set; }
    }
}
