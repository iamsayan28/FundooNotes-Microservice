using Fundoo.User.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundoo.User.Infrastructure.Persistence.DatabaseContext
{
    public class UserDbContext : DbContext
    {
        public DbSet<UserEntity> Users => Set<UserEntity>();
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
    }
}
