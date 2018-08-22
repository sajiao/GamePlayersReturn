using Data;
using Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GamePlayersReturnSystemWebAPI.Tests
{
    [TestClass]
    public class UserDBTest
    {
        [TestMethod]
        public void Test_Test()
        {
            var db =new  UserDB();
            User result = null;
            for (int i = 0; i < 30; i++)
            {
               
                result = db.Add(new User()
                {
                    Id = "TestId-" + DateTime.Now.ToString("yyMMddHHmmss"),
                    Name = "Test-" + DateTime.Now.ToString("yyMMddHHmmss"),
                    NickName = "NickName",
                    Email = "email@email.com",
                    Password = "123456",
                    CreatedTime = DateTime.Now
                });
                Thread.Sleep(1000);

            }
           
            Assert.IsNotNull(result);
        }

    }
}
