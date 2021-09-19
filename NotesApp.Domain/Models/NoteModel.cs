using SEDC.NotesApp.Shared.Enums;
using System.Collections.Generic;

namespace NotesApp.Domain.Models
{
    public class NoteModel
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Color { get; set; }

        public List<Tag> Tags { get; set; }

        public TagType Tag { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public List<NoteModel> NoteModels { get; set; }
    }
}