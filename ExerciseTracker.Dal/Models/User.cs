﻿using System;
using System.Collections.Generic;

namespace ExerciseTracker.Dal.Models
{
    public partial class User
    {
        public User()
        {
            Exercises = new HashSet<Exercise>();
        }

        public Guid UserId { get; set; }
        public string UserName { get; set; } = null!;

        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}
