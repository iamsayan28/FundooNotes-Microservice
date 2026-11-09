using Fundoo.User.Application.Abstraction;
using Fundoo.User.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Fundoo.User.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task RegisterUser(string firstName, string lastName, string email, string password)
        {
            await _userRepository.AddUser(new UserEntity()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            });
        }

        public async Task<bool> LoginUser(string email, string password)
        {
            var user = await _userRepository.GetUserByEmailId(email);
            
            if (user == null) return false;

            if (user.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}