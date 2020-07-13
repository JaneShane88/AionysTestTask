using Aionys.BLL.DTO;
using Aionys.BLL.Interfaces;
using Aionys.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aionys.BLL.Services
{
    public class MapService : IMapService
    {
        public NoteDTO ToNoteDTO(Note note)
        {
            if (note == null)
            {
                return null;
            }
            return new NoteDTO
            {
                Id = note.Id ?? 0,
                Text = note.Text,
                Date = note.Date
            };
        }

        public List<NoteDTO> ToListNoteDTO(List<Note> notes)
        {
            return new List<NoteDTO>(notes.Select(ToNoteDTO).ToList());
        }
    }
}
