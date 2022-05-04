using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Modules.Modules
{
    public class ExerciseViewModel
    {
        [Required(ErrorMessage = "UserID is required.")]
        public Guid UserId { get; set; }
        public string Description { get; set; } = null!;
        public int Duration { get; set; }
        public DateTime? Date { get; set; }
    }
}
