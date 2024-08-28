using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldokkan.Application.Contract
{
    public interface IGenericRepository<T>
    {
        public T Create(T Enitity);
        public T Update(T Enitity);
        public T GetOne(int EntityId);
        public void Delete(T EntityId);
        public IQueryable<T> GetAll();
    }
}
