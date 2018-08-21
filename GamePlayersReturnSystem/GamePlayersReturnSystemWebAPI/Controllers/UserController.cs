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
    public class UserController : ApiController
    {   
        // GET: api/User
        public IEnumerable<User> Get([FromUri]User req)
        {
            return UserBiz.GetAll(req);
        }

        // GET: api/User/5
        public User Get(string id)
        {
            return UserBiz.GetById(id);
        }

        // POST: api/User
        public User Post([FromBody]User req)
        {
            return UserBiz.Add(req);
        }

        public User Put([FromBody]User req)
        {
            return UserBiz.Update(req);
        }

        // DELETE: api/User/5
        public bool Delete(string id)
        {
            return UserBiz.Delete(id);
        }
    }
}
