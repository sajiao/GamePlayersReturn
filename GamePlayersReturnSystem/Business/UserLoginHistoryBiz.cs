using DataProvider;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public  class UserLoginHistoryBiz
    {
        private static UserLoginHistoryDBProvider provider = new UserLoginHistoryDBProvider();

        public static UserLoginHistory Add(UserLoginHistory req)
        {
            return provider.DB.Add(req);
        }

        public static UserLoginHistory GetById(string id)
        {
            return provider.DB.GetById(new UserLoginHistory { PlayerId = id });
        }

        public static IEnumerable<UserLoginHistory> GetAll(UserLoginHistory req)
        {
            return provider.DB.GetAll(req);
        }
    }
}
