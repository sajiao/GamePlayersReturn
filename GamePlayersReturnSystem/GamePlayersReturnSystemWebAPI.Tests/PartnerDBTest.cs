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
    public class PartnerDBTest
    {
        [TestMethod]
        public void Test_Add()
        {
            var db = new PartnerDB();
            var result = db.Add(new Partner()
            {

                Name = "TestPartner-" + DateTime.Now.ToString("yyMMddHHmmss"),
                Description = "TestPartner-" + DateTime.Now.ToString("yyMMddHHmmss"),
                BeginTime = DateTime.Now,
                EndTime = DateTime.Now.AddMonths(6),
                CreatedTime = DateTime.Now,
                ConditionJson = JsonConvert.SerializeObject(new PartnerCondition() { Day = 20})
            });

            Assert.IsNotNull(result);
        }

    }
}
