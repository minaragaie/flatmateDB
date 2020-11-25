using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Label { get; set; }
        public Task TaskType { get; set; }
        public User AssignedTo { get; set; }
        public DateTime DueDate { get; set; }
        public Activity ActivityId { get; set; }
        public bool OnProcess { get; set; }
        public bool Repeat { get; set; }
#nullable enable
        public string? Notes { get; set; }
    }
}
