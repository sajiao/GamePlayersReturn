using DataProvider;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class PlayerActivityLogBiz
    {
        private static PlayerActivityLogDBProvider provider = new PlayerActivityLogDBProvider();

        public static PlayerActivityLog Add(PlayerActivityLog req)
        {
            return provider.DB.Add(req);
        }

        public static PlayerActivityLog GetById(int id)
        {
            return provider.DB.GetById(new PlayerActivityLog { Id = id });
        }

        public static IEnumerable<PlayerActivityLog> GetAll(PlayerActivityLog req)
        {
            return provider.DB.GetAll(req);
        }
    }
}
