using Business.PartnerService;
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

        public static async Task<UserLoginResponse> Login(User req) {
            var result = provider.DB.Login(req);
            var loginResult = new UserLoginResponse();
            if (result != null && result.Id != null) {
                //获取所在区
                var player = PlayerBiz.GetById(result.Id,req.AreaId);
                if (player == null || player.Id == null) {
                    //该用户在该区没有找到记录，新增加一条
                    player = PlayerBiz.Add(new Player() { Id = Guid.NewGuid().ToString(), UserId = result.Id, AreaId = req.AreaId, CreatedTime = DateTime.Now });
                }
                if (DataCache.Partners.Count > 0) {
                    //获取上一次用户登陆，包含区域
                    var lastLogin =  UserLoginHistoryBiz.GetById(player.Id);
                    if (lastLogin != null)
                    {
                        DataCache.AddUserLastLoginLog(lastLogin);
                    }
                }
                var param = new PartnerServiceParams()
                {
                    AreaId = req.AreaId,
                    UserId = result.Id,
                    PlayerId = player.Id
                };
                loginResult.Id = result.Id;
                loginResult.Name = result.Name;
                loginResult.NickName = result.NickName;
                loginResult.AreaId = req.AreaId;
               // loginResult.Partners = CheckService(param);
               
                UserLoginHistoryBiz.Add(new UserLoginHistory() { UserId = result.Id, PlayerId = player.Id, AreaId = req.AreaId, LoginTime = DateTime.Now });
            }
            return loginResult;
        }

        private static Dictionary<string, bool> CheckService(PartnerServiceParams param) {
            Dictionary<string, bool> serviceDict = null;
            if (DataCache.Partners != null && DataCache.Partners.Count > 0)
            {
                serviceDict = new Dictionary<string, bool>(DataCache.Partners.Count);
                //并行检查活动
                Parallel.ForEach(DataCache.Partners, p => {
                    param.Obj = p;
                    param.PartnerId = p.Id;
                    var service = PartnerServiceFactory.CreatePayService(p.ServiceName);

                    if (service != null)
                    {
                        var result = service.IsCanJoin(param);
                        serviceDict.Add(p.Name, result);
                        //
                        if (result) {
                            service.Join(param);
                        }
                    }
                    else
                    {
                        serviceDict.Add(p.Name, false);
                    }
                });
            }

            return serviceDict;
        }
    }
}
