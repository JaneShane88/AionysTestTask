using Aionys.DAL.Interfaces;
using Aionys.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aionys.DAL.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private static List<Note> listNote = new List<Note>()
        {
            new Note {Id = 1, Text = "Text1", Date = new DateTime()},
            new Note {Id = 2, Text = "Text2", Date = new DateTime()},
            new Note {Id = 3, Text = "Text3", Date = new DateTime()},
            new Note {Id = 4, Text = "Text4", Date = new DateTime()},
            new Note {Id = 5, Text = "Text5", Date = new DateTime()},
            new Note {Id = 6, Text = "Text6", Date = new DateTime()},
            new Note {Id = 7, Text = "Text7", Date = new DateTime()},
            new Note {Id = 8, Text = "Text8", Date = new DateTime()},
            new Note {Id = 9, Text = "Text9", Date = new DateTime()},
            new Note {Id = 10, Text = "Text10", Date = new DateTime()}
        };

        public List<Note> Get()
        {
            return listNote;
        }

        public Note Get(int id)
        {
            return listNote.FirstOrDefault(n => n.Id == id);
        }

        public Note Post(Note note)
        {
            try
            {
                listNote.Add(note);
                return note;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Note Put(Note note)
        {
            try
            {
                var oldNote = listNote.FirstOrDefault(n => n.Id == note.Id);
                oldNote.Text = note.Text;
                oldNote.Date = DateTime.Now;
                return oldNote;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Note Delete(int id)
        {
            try
            {
                var note = listNote.FirstOrDefault(n => n.Id == id);
                listNote.Remove(note);
                return note;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
