﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FlatmateDB.Models
{
    public enum TaskTypeId : int
	{
        Bedroom = 0,
        Behavior = 1,
        Communication = 2,
        Creativity = 3,
        Communal = 4,
        Exercise = 5,
        Garden = 6,
        Health = 7,
        Kitchen = 8,
        Maintenance = 9,
        Meal = 10,
        Pets = 11,
        Responsibility = 12,
        Shopping = 13,
        Study = 14,
        Washroom = 15,
        Routine = 16,
        Other = 17
    }
	public class TaskType
    {
        [Key]
        public int TaskTypeId { get; set; }
        public int TaskTypeLabel { get; set; }
    }
}