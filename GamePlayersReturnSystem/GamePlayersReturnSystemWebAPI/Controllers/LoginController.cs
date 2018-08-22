using Business;
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
    public class LoginController : ApiController
    {
        // POST: api/Login
        public async Task<UserLoginResponse> Post([FromBody]User req)
        {
            var result = await UserBiz.Login(req);
            return result;
        }
    }
}
