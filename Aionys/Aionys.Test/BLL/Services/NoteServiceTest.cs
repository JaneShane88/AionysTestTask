using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Aionys.DAL.Interfaces;
using Aionys.DAL.Models;
using Aionys.BLL.Interfaces;
using Aionys.BLL.Services;
using Aionys.BLL.DTO;
using Aionys.DAL.Repositories;

namespace Aionys.Test.BLL.Services
{
    class NoteServiceTest
    {
        private Mock<INoteRepository> _mockINoteRepository;
        private Mock<IMapService> _mockIMapService;
        private NoteService noteService;

        [SetUp]
        public void Setup()
        {
            _mockINoteRepository = new Mock<INoteRepository>();
            _mockIMapService = new Mock<IMapService>();
        }

        [Test]
        public void GetList_listsAreEqual()
        {
            var expected = new List<NoteDTO>
            {
                new NoteDTO {Id = 1, Text = "Text1", Date = new DateTime()},
                new NoteDTO {Id = 2, Text = "Text2", Date = new DateTime()},
            };
            var notes = new List<Note>
            {
                new Note {Id = 1, Text = "Text1", Date = new DateTime()},
                new Note {Id = 2, Text = "Text2", Date = new DateTime()},
            };
            _mockINoteRepository.Setup(r => r.Get()).Returns(notes);
            noteService = new NoteService(_mockINoteRepository.Object, new MapService());

            var actual = noteService.GetList();

            Assert.AreEqual(expected.Count, actual.Count);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Get_ItemFound()
        {
            var expected = new NoteDTO { Id = 1, Text = "Text1", Date = new DateTime() };
            noteService = new NoteService(new NoteRepository(), new MapService());

            var actual = noteService.Get(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Get_ItemNotFound()
        {
            noteService = new NoteService(new NoteRepository(), new MapService());

            var actual = noteService.Get(0);

            Assert.Null(actual);
        }
    }
}
