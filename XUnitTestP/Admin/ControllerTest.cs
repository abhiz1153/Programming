// --------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=ControllerTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------
namespace XUnitTestP.Admin
{
    using BussinessManager.Interface;
    using Common.Models.AdminModels;
    using FundooNoteApi.Controllers;
    using Moq;
    using Xunit;

    /// <summary>
    /// public class ControllerTest
    /// </summary>
    public class ControllerTest
    {
        /// <summary>
        /// Adds the admin.
        /// </summary>
        [Fact]
        public void AddAdmin()
        {
            var service = new Mock<IAdmin>();
            var controller = new AdminController(service.Object);
            var add = new AdminLoginModel()
            {
                FirstName = "Abhishek",
                LastName = "Sharma",
                Email = "abhiz@gmail.com",
                Password = "pasworedeedc"
            };
            var data = controller.AddAdminAsync(add);
            Assert.NotNull(data);
        }

        /// <summary>
        /// Admins the login.
        /// </summary>
        [Fact]
        public void AdminLogin()
        {
            var service = new Mock<IAdmin>();
            var controller = new AdminController(service.Object);
            var add = new AdminLoginModel()
            {
                Email = "abhiz@gmail.com",
                Password = "pasworedeedc"
            };
            var data = controller.LoginAsync(add);
            Assert.NotNull(data);
        }
    }
}
