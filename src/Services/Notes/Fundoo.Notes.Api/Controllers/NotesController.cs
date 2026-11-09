using Fundoo.Notes.Api.Contracts;
using Fundoo.Notes.Application.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Fundoo.Notes.Api.Controllers
{
    [ApiController]
    [Route("api/notes")]
    public class NotesController : ControllerBase
    {
        private readonly NoteService _noteService;
        public NotesController(NoteService noteService)
        {
            _noteService = noteService;
        }

        [Route("create-note")]
        [HttpPost]
        public async Task<IActionResult> CreateNote([FromBody] CreateNoteRequest createNote)
        {
            await _noteService.CreateNote(createNote.Name, createNote.Description);
            return Ok("Note Created successfully");
        }

        [Route("delete-note/{noteId}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteNote([FromRoute] int noteId)
        {
            var result = await _noteService.DeleteNote(noteId);
            if (result) return Ok("Note Deleted successfully");
            else return BadRequest("Note wasn't deleted.");
        }
    }
}
