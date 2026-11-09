using Fundoo.Notes.Application.Abstraction;
using Fundoo.Notes.Domain.Entity;
using Fundoo.Notes.Infrastructure.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundoo.Notes.Infrastructure.Persistence
{
    public class NoteRepository : INoteRepository
    {
        private readonly NoteDbContext _dbContext;
        public NoteRepository(NoteDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddNote(NoteEntity note)
        {
            _dbContext.Notes.Add(note);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteNote(int noteId)
        {
            var note = await _dbContext.Notes.FirstOrDefaultAsync(note => note.Id == noteId);

            if (note == null) return false;
                
            _dbContext.Notes.Remove(note);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
