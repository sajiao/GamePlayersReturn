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
        public static List<UserLoginHistory> UserLastLoginLog = new List<UserLoginHistory>();

        static DataCache() {
            Partners = PartnerBiz.GetAll(new Partner()).ToList();
        }

        public static void AddUserLastLoginLog(UserLoginHistory req) {
            var result = UserLastLoginLog.FirstOrDefault(u => u.PlayerId == req.PlayerId);
            if (result != null) {
                UserLastLoginLog.Remove(result);
            }
           
            UserLastLoginLog.Add(req);
            
        }

        public static UserLoginHistory GetUserLastLoginLog(string playerId) {
            return UserLastLoginLog.FirstOrDefault(u => u.PlayerId == playerId);
        }

    }
}
