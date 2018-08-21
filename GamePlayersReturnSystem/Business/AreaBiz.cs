using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;
using Entity;

namespace Business
{
   public class AreaBiz
    {
        private static AreaDBProvider provider = new AreaDBProvider();

        public static Area Add(Area req)
        {
            return provider.DB.Add(req);
        }

        public static Area Update(Area req)
        {
            return provider.DB.Update(req);
        }

        public static bool Delete(int id)
        {
            return provider.DB.Delete(new Area { Id = id });
        }

        public static Area GetById(int id)
        {
            return provider.DB.GetById(new Area { Id = id });
        }

        public static IEnumerable<Area> GetAll(Area req)
        {
            return provider.DB.GetAll(req);
        }
    }
}
