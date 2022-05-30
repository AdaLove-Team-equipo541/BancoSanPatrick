using Ardalis.Specification;

namespace SanPatrick.Application.Interfaces.Persistence
{
    public interface IRepositoryAsync<T> : IRepositoryBase<T> where T : class
    {
    }
    public interface IReadRerpositoryAsync<T> : IReadRepositoryBase<T> where T : class
    {

    }
}
