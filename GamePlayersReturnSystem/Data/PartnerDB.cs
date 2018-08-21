using IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PartnerDB : IPartner
    {
        public Partner Add<Partner>(Partner req)
        {

            var result = SqlHelper.Exucute(Const.PartnerInsertSql, req);
            if (result > 0)
                return GetById(req);
            return req;
        }

        public Partner Update<Partner>(Partner req)
        {
            var result = SqlHelper.Exucute(Const.PartnerUpdateSql, req);
            if (result > 0)
                return GetById(req);
            return req;
        }

        public bool Delete<Partner>(Partner req)
        {
            var result = SqlHelper.Exucute(Const.PartnerDeleteSql, req);
            return result > 0;
        }

        public Partner GetById<Partner>(Partner req)
        {
            return SqlHelper.QueryFirst<Partner>(Const.PartnerGetByIdSql, req);
        }

        public IEnumerable<Partner> GetAll<Partner>(Partner req)
        {
           
            return SqlHelper.Query<Partner>(Const.PartnerGetAllSql, req);
        }
    }
}
