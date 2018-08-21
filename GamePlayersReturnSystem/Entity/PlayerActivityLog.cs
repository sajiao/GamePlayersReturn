using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class PlayerActivityLog
    {
        public int Id { get; set; }

        public int PartnerId { get; set; }

        public string PlayerId { get; set; }

        public DateTime TakePartInTime { get; set; }
    }
}
