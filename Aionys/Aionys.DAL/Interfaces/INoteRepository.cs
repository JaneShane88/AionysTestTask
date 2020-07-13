using Aionys.DAL.Models;
using System.Collections.Generic;

namespace Aionys.DAL.Interfaces
{
    public interface INoteRepository
    {
        List<Note> Get();
        Note Get(int id);
        Note Post(Note note);
        Note Put(Note note);
        Note Delete(int id);
    }
}
