﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatmateAPI.Models
{
    [Table("UserInvitation")]
    public class UserInvitation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
      
        public bool Accepted { get; set; }
        [ForeignKey("House")]
        public int? HouseId { get; set; }
        public House House { get; set; }

        #region Inviter
        [ForeignKey("Inviter")]
        public string InviterId { get; set; }
        public User Inviter { get; set; }
        #endregion

        [ForeignKey("Invitee")]
        public string InviteeId { get; set; }
        public User Invitee { get; set; }
        public string CreatedAt { get; set; }
    }
}
