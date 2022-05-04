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
    internal class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task CreateUser(UserViewModel exerciseModel)
        {
            await _userRepository.CreateUser(new Dal.Models.User()
            {
                UserId = Guid.NewGuid(),
                UserName = exerciseModel.UserName
            });
        }

        public async Task<List<User>> GetAllUserExercises()
        {
            return await _userRepository.GetAllUsers();
        }
    }
}
