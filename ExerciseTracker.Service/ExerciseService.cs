using ExerciseTracker.Dal.Models;
using ExerciseTracker.Dal.Repository;
using ExerciseTracker.Modules.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Service
{
    public class ExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;

        public ExerciseService(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }

        public async Task CreateExercise(ExerciseViewModel exerciseModel)
        {
            await _exerciseRepository.CreateExercise(new Dal.Models.Exercise()
            {
                UserId = exerciseModel.UserId,
                Description = exerciseModel.Description,
                Duration = exerciseModel.Duration,
                Date = exerciseModel.Date,
                ExerciseId = Guid.NewGuid()
            });
        }

        public async Task<List<ExerciseViewModel>> GetUserExercises(Guid UserID, DateTime? from, DateTime? to, int? limit)
        {
            var exerciseList = await _exerciseRepository.GetUserExercises(UserID, from, to, limit);

            return exerciseList.Select(a => new ExerciseViewModel()
            {
                Date = a.Date,
                Description = a.Description,
                Duration = a.Duration,
                UserId = a.UserId,
            }).ToList();
        }
    }
}
