using Ardalis.Specification.EntityFrameworkCore;
using SanPatrick.Application.Interfaces;
using SanPatrick.Persistence.Contexts;

namespace SanPatrick.Persistence.Repository
{
    public class RepositoryAsync<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {
        private readonly ApplicationContext _context;

        public RepositoryAsync(ApplicationContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}
