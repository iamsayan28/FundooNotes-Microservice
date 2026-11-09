using Fundoo.Notes.Application.Abstraction;
using Fundoo.Notes.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundoo.Notes.Application.Services
{
    public class NoteService
    {
        private readonly INoteRepository _noteRepository;
        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }
        public async Task CreateNote(string name, string? description)
        {
            await _noteRepository.AddNote(new NoteEntity()
            {
                Name = name,
                Description = description,
                CreatedOn = DateTime.UtcNow
            });
        }

        public async Task<bool> DeleteNote(int id)
        {
            return await _noteRepository.DeleteNote(id);
        }
    }
}
