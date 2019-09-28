// <copyright file=ControllerTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------
namespace XUnitTestP.Label
{
    using BussinessManager.Interface;
    using Common.Models.LabelModels;
    using FundooNoteApi.Controllers;
    using Moq;
    using Xunit;
    /// <summary>
    ///  public class for ControllerTest
    /// </summary>
    public class ControllerTest
    {
        /// <summary>
        /// Adds the label.
        /// </summary>
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
        /// <summary>
        /// Updates the label.
        /// </summary>
        [Fact]
        public void UpdateLabel()
        {
            var service = new Mock<ILabel>();
            var controller = new LabelController(service.Object);
            var update = new LabelModel()
            {
                Email = "abhishek@gmail.com",
                Label = "update"

            };
            var data = controller.Add(update);
            Assert.NotNull(data);
        }
        /// <summary>
        /// Deletes the label.
        /// </summary>
        [Fact]
        public void DeleteLabel()
        {
            var service = new Mock<ILabel>();
            var controller = new LabelController(service.Object);
            var data = controller.Delete(1);
            Assert.NotNull(data);
        }
    }
}
