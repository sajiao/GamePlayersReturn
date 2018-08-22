using Business.PartnerService;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GamePlayersReturnSystemWebAPI.Controllers
{
    public class PlayerReturnController : ApiController
    {
        private string serverName = "PlayerReturn";
        // POST: api/PlayerReturn
        public async Task<bool> Post([FromBody]PartnerServiceParams req)
        {
            if (req == null || req.AreaId == 0 || string.IsNullOrEmpty(req.PlayerId) || string.IsNullOrEmpty(req.UserId))
                return false;

            var result = false;
            var service = PartnerServiceFactory.CreatePayService(serverName);
            if (service != null) {
               result = service.IsCanJoin(req);
            }
            return result;
        }

        // PUT: api/PlayerReturn
        public async Task<bool> Put([FromBody]PartnerServiceParams req)
        {
            if (req == null || req.AreaId == 0 || string.IsNullOrEmpty(req.PlayerId) || string.IsNullOrEmpty(req.UserId))
                return false;

            var result = false;
            var service = PartnerServiceFactory.CreatePayService(serverName);
            if (service != null)
            {
                result = service.Join(req);
            }
            return result;
        }

    }
}
