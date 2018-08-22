using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.PartnerService
{

    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class PartnerServiceAttribute : Attribute
    {
        public string PartnerServiceName { get; set; }

        public PartnerServiceAttribute(string partnerServiceName)
        {
            this.PartnerServiceName = partnerServiceName;
        }
    }
}
