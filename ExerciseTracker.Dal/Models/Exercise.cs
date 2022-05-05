using System;
using System.Collections.Generic;

namespace ExerciseTracker.Dal.Models
{
    public partial class Exercise
    {
        public Guid ExerciseId { get; set; }
        public Guid UserId { get; set; }
        public string Description { get; set; } = null!;
        public int Duration { get; set; }
        public DateTime? Date { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
