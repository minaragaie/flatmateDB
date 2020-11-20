using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateDB.Models
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Label { get; set; }
        public int TaskType { get; set; }
        public int AssignedTo { get; set; }
        public DateTime DueDate { get; set; }
        public bool OnProcess { get; set; }
        public bool Repeat { get; set; }
#nullable enable
        public string? Notes { get; set; }
        public int ActivityId { get; set; }
    }
}
