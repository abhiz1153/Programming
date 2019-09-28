// <copyright file=ControllerTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------
namespace XUnitTestP.Notes
{
    using BussinessManager.Interface;
    using Common.Models.NotesModels;
    using FundooNoteApi.Controllers;
    using Moq;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xunit;
    /// <summary>
    /// public calss for ControllerTest
    /// </summary>
    public class ControllerTest
    {
        /// <summary>
        /// Adds the notes.
        /// </summary>
        [Fact]
        public void AddNotes()
        {
            var service = new Mock<INotes>();
            var controller = new NotesController(service.Object);
            var add = new NotesModel()
            {
                Id = 1,
                Email = "abhishek@gmail.com",
                Title = "Title",
                Description = "Description",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Images = "Images",
                Color = "White"
            };
            var data = controller.Add(add);
            Assert.NotNull(data);
        }
        /// <summary>
        /// Updates the notes.
        /// </summary>
        [Fact]
        public void UpdateNotes()
        {
            var service = new Mock<INotes>();
            var controller = new NotesController(service.Object);
            var add = new NotesModel()
            {
                Id = 1,
                Email = "abhis@gmail.com",
                Title = "Eng",
                Description = "Descrip",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Images = "Comming Soon",
                Color = "Black"
            };
            var data = controller.Update(add);
            Assert.NotNull(data);
        }
        /// <summary>
        /// Deletes the notes.
        /// </summary>
        [Fact]
        public void DeleteNotes()
        {
            var service = new Mock<INotes>();
            var controller = new NotesController(service.Object);            
            var data = controller.Delete(1);
            Assert.NotNull(data);
        }
    }
}
