using Data;
using Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace GamePlayersReturnSystemWebAPI.Tests
{
    [TestClass]
    public class AreaDBTest
    {
        [TestMethod]
        public void Test_Add()
        {
            var db = new AreaDB();
            var result = db.Add(new Area()
            {
                AreaName = "TestArea-" + DateTime.Now.ToString("yyMMddHHmmss"),
                CreatedTime = DateTime.Now,
     
            });

            Assert.IsNotNull(result);
        }

    }
}
