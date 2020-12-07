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
        
        public DutyType Type { get; set; }
        [ForeignKey("Type")]
        public int DutyTypeId { get; set; }
        public User AssignedTo { get; set; }
        [ForeignKey("AssignedTo")]
        public string AssignedToId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool MarkAsDone { get; set; }
        public string Edited { get; set; }
        public House House { get; set; }
        [ForeignKey("House")]
        public int HouseId { get; set; }
        public int Privilege { get; set; }
        public string CreatedAt { get; set; }
        public bool OnProcess { get; set; }
        public bool Repeat { get; set; }
        public bool IsStarred { get; set; }
        public bool IsImportant { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public User DutyCreator { get; set; }
        [ForeignKey("DutyCreator")]
        public string UserId { get; set; }
        #nullable enable
        [MaxLength(200)]
        public string? Notes { get; set; }
        
       
    }
}
