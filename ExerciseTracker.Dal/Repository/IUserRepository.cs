using ExerciseTracker.Dal.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Dal.Repository
{
    public interface IUserRepository
    {
        Task CreateUser();
        Task<List<User>> GetAllUsers();
    }
}
