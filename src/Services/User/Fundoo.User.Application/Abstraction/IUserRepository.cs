using Fundoo.User.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundoo.User.Application.Abstraction
{
    public interface IUserRepository
    {
        public Task AddUser(UserEntity user);
        public Task<UserEntity?> GetUserByEmailId(string email);
    }
}
