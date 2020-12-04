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
        //[ForeignKey("User")]
        public int AssignedTo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool MarkAsDone { get; set; }
        public DateTime? Edited { get; set; }
        [ForeignKey("House")]
        public int HouseId { get; set; }
        public int Privilege { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool OnProcess { get; set; }
        public bool Repeat { get; set; }
        public bool IsStarred { get; set; }
        public bool IsImportant { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
#nullable enable
        [MaxLength(200)]
        public string? Notes { get; set; }
        //[ForeignKey("User")]
        public int UserId { get; set; }
    }
}
