using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotesApp.Domain;
using NotesApp.Services.Implementations;
using NotesApp.Services.Interfaces;
using SEDC.NotesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.NotesApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotesController : ControllerBase
    {
        private INoteService _noteService;
        public NotesController()
        {
            _noteService = new NoteService();
        }

        [HttpGet]
        public ActionResult<List<NoteModel>> Get(NoteModel noteModel)
        {
            return _noteService.GetAllNotes(noteModel);
        }
        [HttpGet("{id}")]
        public ActionResult<NoteModel> Get(int id)
        {
            return _noteService.GetNoteById(id);
        }
        [HttpPost]
        public IActionResult Post([FromBody] NoteModel noteModel)
        {
            _noteService.AddNote(noteModel);
            return StatusCode(StatusCodes.Status201Created, "Note created!");
        }

        [HttpPut]

        public IActionResult Put([FromBody] NoteModel noteModel)
        {
            _noteService.UpdateNote(noteModel);
            return StatusCode(StatusCodes.Status204NoContent, "Note updated!");
        }
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            _noteService.DeleteNote(id);
            return StatusCode(StatusCodes.Status204NoContent, "Note deleted!");
        }
    }
}
