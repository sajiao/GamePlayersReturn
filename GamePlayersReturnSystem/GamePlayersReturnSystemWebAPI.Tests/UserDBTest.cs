using Data;
using Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var result =  db.Add(new User() {
                Id= "TestId-" + DateTime.Now.ToString("yyMMddHHmmss"),
                Name ="Test-"+ DateTime.Now.ToString("yyMMddHHmmss"),
                NickName = "NickName",
                Email ="email@email.com",
                Password ="123456",
                CreatedTime = DateTime.Now
            });

            Assert.IsNotNull(result);
        }

    }
}
