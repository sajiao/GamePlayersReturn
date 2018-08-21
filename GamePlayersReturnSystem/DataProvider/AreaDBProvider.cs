using Data;
using IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
  public  class AreaDBProvider
    {
        public IArea DB;
        public AreaDBProvider()
        {
            InitDB(DbType.Mysql);
        }
        public void InitDB(DbType dbType)
        {
            if (dbType == DbType.Mysql)
            {
                DB = new AreaDB();
            }
        }
    }
}
