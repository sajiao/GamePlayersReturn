using IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PlayerDB : IPlayer
    {
        public Player Add<Player>(Player req)
        {

            var result = SqlHelper.Exucute(Const.PlayerInsertSql, req);
            if (result > 0)
                return GetById(req);
            return req;
        }

        public Player Update<Player>(Player req)
        {
            var result = SqlHelper.Exucute(Const.PlayerUpdateSql, req);
            if (result > 0)
                return GetById(req);
            return req;
        }

        public bool Delete<Player>(Player req)
        {
            var result = SqlHelper.Exucute(Const.PlayerDeleteSql, req);
            return result > 0;
        }

        public Player GetById<Player>(Player req)
        {
            return SqlHelper.QueryFirst<Player>(Const.PlayerGetByIdSql, req);
        }

        public IEnumerable<Player> GetAll<Player>(Player req)
        {
            return SqlHelper.Query<Player>(Const.PlayerGetAllSql, req);
        }
    }
}
