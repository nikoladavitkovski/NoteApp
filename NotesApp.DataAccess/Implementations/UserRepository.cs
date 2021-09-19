using NoteApp.Domain;
using NotesApp.Domain;
using NotesApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotesApp.DataAccess.Implementations
{
    public class UserRepository : IRepository<User>
    {
        private NotesAppDbContext _notesAppDbContext;

        public UserRepository(NotesAppDbContext notesAppDbContext)
        {
            _notesAppDbContext = notesAppDbContext;
        }

        public void Add(Note noteForDb)
        {
            
        }

        public void Delete(int id)
        {
            
        }

        public void Delete(User user)
        {
            _notesAppDbContext.Users.Remove(user);
            _notesAppDbContext.SaveChanges();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            return _notesAppDbContext.Users.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(User user)
        {
            _notesAppDbContext.Users.Add(user);
            _notesAppDbContext.SaveChanges();
        }

        public void Update(User user)
        {
            _notesAppDbContext.Users.Update(user);
            _notesAppDbContext.SaveChanges();
        }
    }
}
