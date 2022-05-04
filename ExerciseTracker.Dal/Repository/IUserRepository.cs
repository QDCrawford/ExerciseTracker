using ExerciseTracker.Dal.Models;
using ExerciseTracker.Dal.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Dal.Repository
{
    public interface IUserRepository
    {
        Task CreateUser(User user);
        Task<List<User>> GetAllUsers();
    }
}
