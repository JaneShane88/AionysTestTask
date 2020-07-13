using Aionys.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aionys.BLL.Interfaces
{
    public interface INoteService
    {
        List<NoteDTO> GetList();

        NoteDTO Get(int id);

        NoteDTO Post(NoteDTO noteDTO);

        NoteDTO Put(int id, NoteDTO noteDTO);

        NoteDTO Delete(int id);
    }
}
