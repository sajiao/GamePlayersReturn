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

        private static void SetPartnerCache() {
            DataCache.Partners = GetAll(new Partner()).ToList();
        }
        public static Partner Add(Partner req)
        {
            
            var result = provider.DB.Add(req);
            SetPartnerCache();
            return result;
        }

        public static Partner Update(Partner req)
        {
            var result = provider.DB.Update(req);
            SetPartnerCache();
            return result;
        }

        public static bool Delete(int id)
        {
            var result = provider.DB.Delete(new Partner { Id = id });
            SetPartnerCache();
            return result;
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
