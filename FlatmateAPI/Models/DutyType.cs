using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    public enum DutyTypeLabel : int
	{
        [Description("Bedroom")]
        Bedroom = 1,
        [Description("Behavior")]
        Behavior = 2,
        [Description("Communication")]
        Communication = 3,
        [Description("Creativity")]
        Creativity = 4,
        [Description("Communal")]
        Communal = 5,
        [Description("Exercise")]
        Exercise = 6,
        [Description("Garden")]
        Garden = 7,
        [Description("Health")]
        Health = 8,
        [Description("Kitchen")]
        Kitchen = 9,
        [Description("Maintenance")]
        Maintenance = 10,
        [Description("Meal")]
        Meal = 11,
        [Description("Pets")]
        Pets = 12,
        [Description("Responsibility")]
        Responsibility = 13,
        [Description("Shopping")]
        Shopping = 14,
        [Description("Study")]
        Study = 15,
        [Description("Washroom")]
        Washroom = 16,
        [Description("Routine")]
        Routine = 17,
        [Description("Other")]
        Other = 18,
    }
    [Table("DutyType")]
    public class DutyType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(40)]
        public string Label { get; set; }
        public List<Duty> Duties { get; set; }
    }
}
