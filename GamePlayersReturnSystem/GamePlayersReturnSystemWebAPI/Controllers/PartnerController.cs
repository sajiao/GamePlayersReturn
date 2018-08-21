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
    public class PartnerController : ApiController
    {
        // GET: api/Partner
        public IEnumerable<Partner> Get([FromUri]Partner req)
        {
            return PartnerBiz.GetAll(req);
        }

        // GET: api/Partner/5
        public Partner Get(int id)
        {
            return PartnerBiz.GetById(id);
        }

        // POST: api/Partner
        public Partner Post([FromBody]Partner req)
        {
            return PartnerBiz.Add(req);
        }

        public Partner Put([FromBody]Partner req)
        {
            return PartnerBiz.Update(req);
        }

        // DELETE: api/Partner/5
        public bool Delete(int id)
        {
            return PartnerBiz.Delete(id);
        }
    }
}
