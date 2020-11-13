using System;
using System.ComponentModel.DataAnnotations;

namespace FlatmateDB.Models
{
    public enum ActivityTypeId : int
    {
        WriteComment = 0,
        EditComment = 1,
        CreateList = 2,
        EditList = 3,
        WritePost = 4,
        EditPost = 5,
        CreateTask = 6,
        EditTask = 7,
        MarkAsDone = 8,
        InvteFriend = 9
    }
    public class ActivityType
    {
        [Key]
        public int ActivityTypeId { get; set; }
        public string ActivityTypeLabel { get; set; }
    }
}
