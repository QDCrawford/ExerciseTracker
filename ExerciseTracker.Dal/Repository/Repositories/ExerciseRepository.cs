using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseTracker.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.Dal.Repository.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly ExerciseTrackerDBContext _context;

        public ExerciseRepository(ExerciseTrackerDBContext context)
        {
            _context = context;
        }
        public async Task CreateExercise(Exercise exercise)
        {
            _context.Exercises.Add(exercise);
            _context.SaveChanges();
        }
        public async Task<List<Exercise>> GetUserExercises(Guid UserID, DateTime? from, DateTime? to, int? limit)
        {
            var query = _context.Exercises.AsQueryable().Where(e => e.UserId == UserID);
            
            if (limit != null && limit > 0)
            {
                query = query.Take(limit.Value);
            }
            if (from != null)
            {
                query = query.Where(e => e.Date < from);
            }
            if (to != null)
            {
                query = query.Where(e => e.Date > to);
            }

            return await query.ToListAsync();
        }
    }
}
