using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GamePlayersReturnSystemWebAPI;
using GamePlayersReturnSystemWebAPI.Controllers;
using Entity;
using System.Threading.Tasks;

namespace GamePlayersReturnSystemWebAPI.Tests.Controllers
{
    [TestClass]
    public class LoginControllerTest
    {
        private User user;
        private LoginController controller;

        [TestInitialize]
        public void TestInitialize()
        {
            controller = new LoginController();
            user = new User()
            {
                Id = "Test-180821024237",
                Name = "Test-180821024237",
                NickName = "NickName",
                Email = "email@email.com",
                Password = "123456",
                AreaId = 1
            };
          
        }

        [TestMethod]
        public void Post()
        {
            var userController = new UserController();
            var users = userController.Get(new User()).ToList();
 
            Parallel.ForEach(users, u => {
                u.AreaId = 1;
                controller.Post(u);
           });

        }

    }
}
