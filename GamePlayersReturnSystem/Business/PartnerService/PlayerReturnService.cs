using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Business.PartnerService
{
    [PartnerService("PlayerReturn")]
    public class PlayerReturnService: IPartnerService
    {

       public bool IsCanJoin(PartnerServiceParams param)
        {
            if (string.IsNullOrEmpty(param.PlayerId) || param.Obj == null || param.AreaId <= 0)
                return false;

            var result = false;
            try
            {
                var partner = param.Obj as Partner;
                if (partner != null)
                {
                    if (partner.BeginTime <= DateTime.Now && partner.EndTime > DateTime.Now)
                    {
                        var condition = JsonConvert.DeserializeObject<PartnerCondition>(partner.ConditionJson);
                        if (condition != null)
                        {
                            var lastLogin = DataCache.GetUserLastLoginLog(param.PlayerId);
                            if (lastLogin != null && DateTime.Now.Subtract(lastLogin.LoginTime).Days >= condition.Day) {
                              var playerResult = PlayerActivityLogBiz.GetById(param.PlayerId, param.PartnerId);
                                if (playerResult == null || playerResult.Id == 0) {
                                    result = true;
                                }
                            }
                              
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //log
                throw ex;
            }

            return result;
        }


        public bool Join(PartnerServiceParams param)
        {
            var execResult = PlayerActivityLogBiz.Add(new PlayerActivityLog()
            {
                PartnerId = param.PartnerId,
                PlayerId = param.PlayerId,
                TakePartInTime = DateTime.Now
            });
            
            return execResult.Id > 0;
        }
    }
}
