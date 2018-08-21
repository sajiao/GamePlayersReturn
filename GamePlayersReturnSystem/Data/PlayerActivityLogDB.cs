using Entity;
using IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PlayerActivityLogDB :IPlayerActivityLog
    {
        public PlayerActivityLog Add<PlayerActivityLog>(PlayerActivityLog req)
        {
            var result = SqlHelper.Exucute(Const.PlayerActivityLogInsertSql, req);
            if (result > 0)
                return GetById(req);
            return req;
        }

        public PlayerActivityLog GetById<PlayerActivityLog>(PlayerActivityLog req)
        {
            return SqlHelper.QueryFirst<PlayerActivityLog>(Const.PlayerActivityLogGetByIdSql, req);
        }

        public IEnumerable<PlayerActivityLog> GetAll<PlayerActivityLog>(PlayerActivityLog req)
        {
           
            return SqlHelper.Query<PlayerActivityLog>(Const.PlayerActivityLogGetAllSql, req);
        }
    }
}
