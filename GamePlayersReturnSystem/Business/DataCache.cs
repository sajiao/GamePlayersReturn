using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public static class DataCache
    {
        public static List<Partner> Partners;

        static DataCache() {
            Partners = PartnerBiz.GetAll(new Partner()).ToList();
        }
    }
}
