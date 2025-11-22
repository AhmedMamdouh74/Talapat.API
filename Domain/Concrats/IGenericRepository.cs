using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrats
{
    public interface IGenericRepository<T,TK> where T:BaseEntity<TK>
    {
        Task<T> GetByIdAsync(TK id);
        Task<IReadOnlyList<T>> GetAllAsync();
      
    }
}
