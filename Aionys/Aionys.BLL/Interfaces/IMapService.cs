using Aionys.BLL.DTO;
using Aionys.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aionys.BLL.Interfaces
{
    public interface IMapService
    {
        NoteDTO ToNoteDTO(Note note);

        List<NoteDTO> ToListNoteDTO(List<Note> notes);
    }
}
