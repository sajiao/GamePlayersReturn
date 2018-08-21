using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IData
{
   public interface IDataBase
    {
        T Add<T>(T req);
        
        T GetById<T>(T req);
       
        IEnumerable<T> GetAll<T>(T req);
    }

    public interface IUpdate
    {
        T Update<T>(T req);
    }

    public interface IDelete
    {
        bool Delete<T>(T req);
    }
}
