using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class PartnerServiceParams
    {
        public string UserId { get; set; }

        public int AreaId { get; set; }

        public string PlayerId { get; set; }

        public int PartnerId { get; set; }

        public object Obj { get; set; }//ConditionJson
    }
}
