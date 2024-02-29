using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T: class
    {
        IUnitOfWork UnitOfWork { get; }
        Task<T> GetIdAsync (int id);
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate);
    }
}
