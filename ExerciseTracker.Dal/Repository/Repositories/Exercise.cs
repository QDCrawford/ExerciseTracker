using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Dal.Repository.Repositories
{
    public class Exercise : IExerciseRepository
    {
        public async Task CreateExercise(Exercise exercise)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Exercise>> GetUserExercises(Guid UserID, DateTime from, DateTime to, int limit)
        {
            throw new NotImplementedException();
        }
    }
}
