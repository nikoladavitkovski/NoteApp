using Microsoft.EntityFrameworkCore;
using NoteApp.Domain;
using NotesApp.Domain;
using NotesApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotesApp.DataAccess
{
    public class NoteRepository : IRepository<NoteModel>
    {
        private NotesAppDbContext _notesAppDbContext;

        public NoteRepository()
        {

        }

        public NoteRepository(NotesAppDbContext notesAppDbContext)
        {
            _notesAppDbContext = notesAppDbContext;
        }

        public void Add(Note noteForDb)
        {

        }

        public void Delete(NoteModel noteModel)
        {
            _notesAppDbContext.Notes.Remove(noteModel);
            _notesAppDbContext.SaveChanges();
        }

        public List<NoteModel> GetAll()
        {
            return _notesAppDbContext.Notes.Include(x => x.User)//join with table users
                .ToList();
        }

        public NoteModel GetById(int id)
        {
            //returns one record from a table in DB(by id)
            return _notesAppDbContext.Notes.Include(x => x.User).FirstOrDefault(x => x.Id == id);
        }

        public void Insert(NoteModel entity)
        {
            _notesAppDbContext.Notes.Add(entity);
            _notesAppDbContext.SaveChanges();
        }

        public void Update(NoteModel entity)
        {
            _notesAppDbContext.Notes.Update(entity);
            _notesAppDbContext.SaveChanges();
        }
    }
}
