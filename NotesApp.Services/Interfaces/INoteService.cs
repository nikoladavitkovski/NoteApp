using NotesApp.Domain;
using SEDC.NotesApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotesApp.Services.Interfaces
{
    public interface INoteService
    {
        List<NoteModel> GetAllNotes(NoteModel noteModel);
        NoteModel GetNoteById(int id);
        void AddNote(NoteModel noteModel);
        void UpdateNote(NoteModel noteModel);
        void DeleteNote(int id);
    }
}
