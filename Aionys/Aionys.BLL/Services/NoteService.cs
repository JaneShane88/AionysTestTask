using Aionys.BLL.DTO;
using Aionys.BLL.Interfaces;
using Aionys.DAL.Interfaces;
using Aionys.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aionys.BLL.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;
        private readonly IMapService _mapService;

        public NoteService (INoteRepository noteRepository, IMapService mapService)
        {
            _noteRepository = noteRepository;
            _mapService = mapService;
        }

        public List<NoteDTO> GetList()
        {
            var notes = _noteRepository.Get();
            return _mapService.ToListNoteDTO(notes);
        }

        public NoteDTO Get(int id)
        {
            var note = _noteRepository.Get(id);
            return _mapService.ToNoteDTO(note);

        }

        public NoteDTO Post(NoteDTO noteDTO)
        {
            int id = _noteRepository.Get().Last().Id + 1 ?? 1; 
            var note = new Note
            {
                Id = id,
                Text = noteDTO.Text,
                Date = DateTime.UtcNow
            };
            return _mapService.ToNoteDTO(_noteRepository.Post(note));
        }

        public NoteDTO Put(int id, NoteDTO noteDTO)
        {
            var note = new Note
            {
                Id = id,
                Text = noteDTO.Text,
                Date = DateTime.UtcNow
            };
            return _mapService.ToNoteDTO(_noteRepository.Put(note));
        }

        public NoteDTO Delete(int id)
        {
            return _mapService.ToNoteDTO(_noteRepository.Delete(id));
        }
    }
}
