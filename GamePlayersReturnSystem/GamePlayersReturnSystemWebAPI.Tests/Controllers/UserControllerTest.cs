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

namespace GamePlayersReturnSystemWebAPI.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        private User user;
        private UserController controller;

        [TestInitialize]
        public void TestInitialize()
        {
            controller = new UserController();
            user = new User()
            {
                Id = "TestId-" + DateTime.Now.ToString("yyMMddHHmmss"),
                Name = "Test-" + DateTime.Now.ToString("yyMMddHHmmss"),
                NickName = "NickName",
                Email = "email@email.com",
                Password = "123456",
                CreatedTime = DateTime.Now
            };
           controller.Post(user);
        }

        [TestMethod]
        public void Post()
        {
            user.Id = user.Id + "0";
            user.NickName = "Post test";
            var result = controller.Post(user);

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void Get()
        {
            UserController controller = new UserController();

            IEnumerable<User> result = controller.Get(user);

            Assert.IsNotNull(result);
            Assert.IsTrue( result.Count() > 0);
           
        }

        [TestMethod]
        public void GetById()
        {
            var result = controller.Get(user.Id);
            Assert.AreEqual(user.Id, result.Id);
        }

        [TestMethod]
        public void Put()
        {
           
            user.Name = "test user put";
            user.UpdatedTime = DateTime.Now;
            controller.Put(user);
            var result = controller.Get(user.Id);
            Assert.AreEqual(user.Name, result.Name);
        }

        [TestMethod]
        public void Delete()
        {
            var result = controller.Delete(user.Id);
            Assert.IsTrue(result);
        }
    }
}
