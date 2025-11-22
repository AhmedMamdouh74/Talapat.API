using Domain;
using Domain.Concrats;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Repos
{
    public class GenericRepository<T, TK> : IGenericRepository<T, TK> where T:BaseEntity<TK>
    {
        private readonly AppDbContext dbContext;

        public GenericRepository(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
           
           return await dbContext.Set<T>().ToListAsync() ;   
        }

        public  async Task<T?> GetByIdAsync(TK id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }
    }
}
