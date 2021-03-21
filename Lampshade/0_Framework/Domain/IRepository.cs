using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework.Domain
{
    // TKey = Type Id
    // T = Type Entity 

    public interface IRepository<Tkey , T>
    {
        T Get(Tkey id);
        List<T> Get();
        void Create(T entity);
        bool Exists(Expression<Func<T, bool>> expression);
        void SaveChanges();
    }
}
