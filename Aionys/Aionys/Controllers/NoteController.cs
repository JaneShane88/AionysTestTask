using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Aionys.BLL.Interfaces;
using Aionys.BLL.DTO;

namespace Aionys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private INoteService _noteService;

        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet]
        public List<NoteDTO> Get()
        {
            return _noteService.GetList();
        }

        [HttpGet("{id}")]
        public NoteDTO Get(int id)
        {
            return _noteService.Get(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NoteDTO noteDTO)
        {
            var note = _noteService.Post(noteDTO);

            return (note != null) ? (IActionResult)Ok() : BadRequest();
        }

        [HttpPut]
        public IActionResult Put([FromBody] NoteDTO noteDTO)
        {
            if (noteDTO.Id <= 0)
            {
                return BadRequest();
            }

            var note = _noteService.Put(noteDTO.Id, noteDTO);

            return (note != null) ? (IActionResult)Ok() : BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var note = _noteService.Delete(id);

            return (note != null) ? (IActionResult)Ok() : BadRequest();
        }
    }
}