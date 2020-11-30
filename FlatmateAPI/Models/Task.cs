using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("Task")]
    public class Task
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(40)]
        public string Label { get; set; }
        [ForeignKey("TaskType")]
        public int TaskTypeId { get; set; }
        [ForeignKey("User")]
        public User AssignedTo { get; set; }
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
