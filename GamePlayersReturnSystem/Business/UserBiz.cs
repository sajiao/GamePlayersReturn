using DataProvider;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class UserBiz
    {
        private static UserDBProvider provider = new UserDBProvider();
        private static UserLoginHistoryDBProvider loginHistoryProvider = new UserLoginHistoryDBProvider();
        private static PlayerDBProvider playerProvider = new PlayerDBProvider();

        public static User Add(User req) {
           return provider.DB.Add(req);
        }

        public static User Update(User req)
        {
            return provider.DB.Update(req);
        }

        public static bool Delete(string id)
        {
            return provider.DB.Delete(new User { Id = id });
        }

        public static User GetById(string id)
        {
            return provider.DB.GetById(new User { Id = id});
        }

        public static IEnumerable<User> GetAll(User req)
        {
            return  provider.DB.GetAll(req);
        }

        public static User Login(User req) {
            var result = provider.DB.Login(req);
            if (result != null && result.Id != null) {
                var player = playerProvider.DB.GetById(new Player() { UserId= result.Id });
                if (player == null || player.Id == null) {
                    player = playerProvider.DB.Add(new Player() { UserId = result.Id, AreaId = result.AreaId, CreatedTime = DateTime.Now });
                }
                if (DataCache.Partners.Count > 0) {
                    var lastLogin = loginHistoryProvider.DB.GetById(new UserLoginHistory() { PlayerId = player.Id });
                    if (lastLogin == null || DateTime.Now.Subtract(lastLogin.LoginTime).Days > 20)
                    {
                        //join 
                    }
                }
               
                loginHistoryProvider.DB.Add(new UserLoginHistory() { UserId = result.Id, PlayerId = player.Id, AreaId = result.AreaId, LoginTime = DateTime.Now });

               
            }
            return result;
        }
    }
}
