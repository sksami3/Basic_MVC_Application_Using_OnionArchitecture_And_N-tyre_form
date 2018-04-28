using Project123.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Project123.Infructructure.Interfaces
{
    public interface IBaseRepository<T>: IDisposable where T: BaseModel
    {
        IEnumerable<T> All();
        T Find(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
