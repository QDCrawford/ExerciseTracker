using ExerciseTracker.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Dal.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ExerciseTrackerDBContext _context;

        public UserRepository(ExerciseTrackerDBContext context)
        {
            _context = context;
        }

        public async Task CreateUser(Models.User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.AsQueryable().ToListAsync();
        }

    }
}
