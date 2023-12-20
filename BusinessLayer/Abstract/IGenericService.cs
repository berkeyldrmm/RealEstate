using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task<T> GetOne(int id);
        Task<IEnumerable<T>> GetAll();
        Task<bool> Insert(T item);
        Task<bool> Update(T item);
        bool DeleteAsync(T item);
        void DeleteRange(IEnumerable<T> items);
    }
}
