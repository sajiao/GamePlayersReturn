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
using Business;

namespace GamePlayersReturnSystemWebAPI.Tests.Controllers
{
    [TestClass]
    public class PlayerReturnControllerTest
    {
        private PlayerReturnController controller;

        [TestInitialize]
        public void TestInitialize()
        {
            controller = new PlayerReturnController();
            var userController = new UserController();
            var users = userController.Get(new User()).ToList();

            Parallel.ForEach(users, u => {
                u.AreaId = 1;
                new LoginController().Post(u);
            });
        }

        [TestMethod]
        public void Post()
        {
            var userController = new UserController();
            var users = userController.Get(new User()).ToList();

            Parallel.ForEach(users, u => {
                u.AreaId = 1;
                var player = PlayerBiz.GetById(u.Id,1);
                if(player != null)
                {
                    var param = new PartnerServiceParams()
                    {
                        PartnerId = 1,
                        UserId = u.Id,
                        AreaId = 1,
                        PlayerId = player.Id
                    };
                    param.Obj = DataCache.Partners.Where(p => p.ServiceName == "PlayerReturn").FirstOrDefault();
                   
                   var result = controller.Post(param);
                    if (result.Result) {
                        controller.Put(param);
                    }
                }
               
            });

        }

    }
}
