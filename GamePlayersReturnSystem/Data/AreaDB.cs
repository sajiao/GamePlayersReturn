using IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class AreaDB : IArea
    {
        public Area Add<Area>(Area req)
        {

            var result = SqlHelper.Exucute(Const.AreaInsertSql, req);
            if (result > 0)
                return GetById(req);
            return req;
        }

        public Area Update<Area>(Area req)
        {
            var result = SqlHelper.Exucute(Const.AreaUpdateSql, req);
            if (result > 0)
                return GetById(req);
            return req;
        }

        public bool Delete<Area>(Area req)
        {
            var result = SqlHelper.Exucute(Const.AreaDeleteSql, req);
            return result > 0;
        }

        public Area GetById<Area>(Area req)
        {
            return SqlHelper.QueryFirst<Area>(Const.AreaGetByIdSql, req);
        }

        public IEnumerable<Area> GetAll<Area>(Area req)
        {
            return SqlHelper.Query<Area>(Const.AreaGetAllSql, req);
        }
    }
}
