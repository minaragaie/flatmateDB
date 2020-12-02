using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    public enum ActivityLabel
    {
        WriteComment,
        EditComment,
        CreateList,
        EditList,
        AddItem,
        WritePost,
        EditPost,
        CreateTask,
        EditTask,
        MarkAsDone,
        InviteFriend,
        CreateHouse
    }
    [Table("ActivityType")]
    public class ActivityType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(40)]
        public ActivityLabel Label { get; set; }
    }
}
