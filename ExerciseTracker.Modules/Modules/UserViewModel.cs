using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Modules.Modules
{
    public class UserViewModel
    {
        public Guid UserID { get; set; }
        [Required(ErrorMessage = "UserName is required.")]
        public string UserName { get; set; }
    }
}
