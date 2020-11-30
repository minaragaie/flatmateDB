using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    public enum TaskTypeLabel : int
	{
        Bedroom,
        Behavior,
        Communication,
        Creativity,
        Communal,
        Exercise,
        Garden,
        Health,
        Kitchen,
        Maintenance,
        Meal,
        Pets,
        Responsibility,
        Shopping,
        Study,
        Washroom,
        Routine,
        Other,
    }
    [Table("TaskType")]
    public class TaskType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(40)]
        public TaskTypeLabel Label { get; set; }
    }
}
