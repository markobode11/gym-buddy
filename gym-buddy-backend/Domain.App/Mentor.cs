﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Domain.App.Identity;
using Domain.Base;

#nullable enable
namespace Domain.App
{
    public class Mentor : DomainEntityId
    {
        [DisplayName("Full name")] public string FullName { get; set; } = default!;
        public string Specialty { get; set; } = null!;

        public DateTime Since { get; set; } = DateTime.Now;
        public string Description { get; set; } = null!;

        public string Email { get; set; } = default!;

        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

        public ICollection<UserMentor>? UserMentors { get; set; }
    }
}