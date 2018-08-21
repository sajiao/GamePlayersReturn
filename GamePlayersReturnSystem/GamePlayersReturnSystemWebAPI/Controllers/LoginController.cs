using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GamePlayersReturnSystemWebAPI.Controllers
{
    public class LoginController : ApiController
    {
        // POST: api/Login
        public HttpResponseMessage Post([FromBody]User req)
        {
            var result = UserBiz.Login(req);
            return new HttpResponseMessage() { };
        }

      
    }
}
