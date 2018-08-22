using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Partner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime BeginTime { get; set; }

        public DateTime EndTime { get; set; }

        public string ConditionJson { get; set; }

        public string ServiceName { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedTime { get; set; }

    }

    public class PartnerCondition {
        public int Day { get; set; }
    }
}
