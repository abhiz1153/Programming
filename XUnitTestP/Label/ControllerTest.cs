using BussinessManager.Interface;
using Common.Models.LabelModels;
using FundooNoteApi.Controllers;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestP.Label
{
    public class ControllerTest
    {
        [Fact]
        public void AddLabel()
        {
            var service = new Mock<ILabel>();
            var controller = new LabelController(service.Object);
            var add = new LabelModel()
            {
                Email = "abhishek@gmail.com",
                Label = "qwerty"
                
            };
            var data = controller.Add(add);
            Assert.NotNull(data);
        }
    }
}
