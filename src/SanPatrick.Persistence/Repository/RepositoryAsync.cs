﻿using Ardalis.Specification.EntityFrameworkCore;
using SanPatrick.Application.Interfaces.Persistence;
using SanPatrick.Persistence.Contexts;

namespace SanPatrick.Persistence.Repository
{
    public class RepositoryAsync<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public RepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}
