using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fundoo.User.Application.Abstraction;
using Fundoo.User.Domain.Entity;
using Fundoo.User.Infrastructure.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
namespace Fundoo.User.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _dbContext;
        public UserRepository(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddUser(UserEntity user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<UserEntity?> GetUserByEmailId(string email)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
