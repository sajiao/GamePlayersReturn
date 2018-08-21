using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Player
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public int AreaId { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
