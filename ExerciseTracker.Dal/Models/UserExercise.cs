using System;
using System.Collections.Generic;

namespace ExerciseTracker.Dal.Models
{
    public partial class UserExercise
    {
        public Guid UserId { get; set; }
        public Guid ExerciseId { get; set; }

        public virtual Exercise Exercise { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
