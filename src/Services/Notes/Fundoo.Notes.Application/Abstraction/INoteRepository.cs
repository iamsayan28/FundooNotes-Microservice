using Fundoo.Notes.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundoo.Notes.Application.Abstraction
{
    public interface INoteRepository
    {
        public Task AddNote(NoteEntity note);
        public Task<bool> DeleteNote(int id);
    }
}
