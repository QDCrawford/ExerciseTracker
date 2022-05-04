using ExerciseTracker.Dal.Models;
using ExerciseTracker.Dal.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Dal.Repository
{
    public interface IExerciseRepository
    {
        Task CreateExercise(Exercise exercise);
        Task<List<Exercise>> GetUserExercises(Guid UserID, DateTime? from, DateTime? to, int limit);
    }
}
