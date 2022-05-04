using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Modules.Modules
{
    internal class Exercise
    {
        [Required(ErrorMessage = "UserID is required.")]
        public Guid UserID { get; set; }

        [Required(ErrorMessage = "ExerciseID is required.")]
        public Guid ExerciseID { get; set; }

        public DateTime? Date { get; set; }

        public string Description { get; set; }

        [MaxLength(60)]
        public int Duration { get; set; }

    }
}
