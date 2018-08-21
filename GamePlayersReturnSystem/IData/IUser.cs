using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IData
{
  public  interface IUser: IDataBase, IUpdate, IDelete
    {
        User Login(User req);
    }
}
