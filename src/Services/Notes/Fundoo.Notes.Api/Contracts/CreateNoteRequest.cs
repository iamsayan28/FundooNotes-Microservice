using System.ComponentModel.DataAnnotations;

namespace Fundoo.Notes.Api.Contracts
{
    public class CreateNoteRequest
    {
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string? Description { get; set; }
    }
}
