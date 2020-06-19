using OutsideBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OutsideBoxApi.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> All();
        T Get(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}
