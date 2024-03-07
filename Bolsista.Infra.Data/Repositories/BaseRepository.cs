using Bolsista.Domain.Interfaces;
using Bolsista.Domain.Interfaces.Repositories;
using Bolsista.Infra.Data.EF;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Bolsista.Infra.Data.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly BolsistaContext _context;
        public BaseRepository(BolsistaContext context) 
        {
            _context = context;
        }
        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetIdAsync(long id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
