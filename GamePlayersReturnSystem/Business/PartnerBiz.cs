using DataProvider;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class PartnerBiz
    {
        private static PartnerDBProvider provider = new PartnerDBProvider();

        public static Partner Add(Partner req)
        {
            return provider.DB.Add(req);
        }

        public static Partner Update(Partner req)
        {
            return provider.DB.Update(req);
        }

        public static bool Delete(int id)
        {
            return provider.DB.Delete(new Partner { Id = id });
        }

        public static Partner GetById(int id)
        {
            return provider.DB.GetById(new Partner { Id = id });
        }

        public static IEnumerable<Partner> GetAll(Partner req)
        {
            return provider.DB.GetAll(req);
        }
    }
}
