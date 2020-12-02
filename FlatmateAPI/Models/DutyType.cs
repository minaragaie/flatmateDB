using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    public enum DutyTypeLabel : int
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
    [Table("DutyType")]
    public class DutyType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(40)]
        public DutyTypeLabel Label { get; set; }
    }
}
