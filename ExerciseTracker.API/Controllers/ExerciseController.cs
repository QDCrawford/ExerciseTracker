using ExerciseTracker.Modules.Modules;
using ExerciseTracker.Service;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ExerciseTracker.API.Controllers
{
    public class ExerciseController : ControllerBase
    {
        private readonly ExerciseService _exerciseService;

        public ExerciseController(ExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [HttpGet("/api/exercise/log")]
        public async Task<List<ExerciseViewModel>> Get([Required]Guid UserID, DateTime? from, DateTime? to, int? limit)
        {
            return await _exerciseService.GetUserExercises(UserID,from,to,limit);
        }

        [HttpPost("/api/exercise/add")]
        public async Task Post([FromBody] ExerciseViewModel exercise)
        {
            await _exerciseService.CreateExercise(exercise);
        }
    }
}
