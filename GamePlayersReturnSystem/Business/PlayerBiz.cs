using DataProvider;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class PlayerBiz
    {
        private static PlayerDBProvider provider = new PlayerDBProvider();

        public static Player Add(Player req)
        {
            return provider.DB.Add(req);
        }

        public static Player Update(Player req)
        {
            return provider.DB.Update(req);
        }

        public static bool Delete(string id)
        {
            return provider.DB.Delete(new Player { Id = id });
        }

        public static Player GetById(string userId, int areaId)
        {
            return provider.DB.GetById(new Player { UserId = userId, AreaId = areaId });
        }

        public static IEnumerable<Player> GetAll(Player req)
        {
            return provider.DB.GetAll(req);
        }
    }
}
