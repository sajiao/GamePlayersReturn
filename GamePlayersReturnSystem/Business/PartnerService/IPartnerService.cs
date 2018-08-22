using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.PartnerService
{
   public interface IPartnerService
    {
        bool IsCanJoin(PartnerServiceParams param);
        bool Join(PartnerServiceParams param);
    }
}
