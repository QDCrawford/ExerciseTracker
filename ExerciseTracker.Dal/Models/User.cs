﻿using System;
using System.Collections.Generic;

namespace ExerciseTracker.Dal.Models
{
    public partial class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; } = null!;
    }
}
