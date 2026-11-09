using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fundoo.Notes;
using Fundoo.Notes.Domain.Entity;

namespace Fundoo.Notes.Infrastructure.Persistence.DatabaseContext
{
    public class NoteDbContext : DbContext
    {
        public DbSet<NoteEntity> Notes => Set<NoteEntity>();
        public NoteDbContext(DbContextOptions<NoteDbContext> options) : base(options) { }

    }
}
