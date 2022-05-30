using Moq;
using SanPatrick.Application.Interfaces.Persistence;
using SanPatrick.Domain.Entities;

namespace SanPAtrick.Application.UnitTests.Mocks
{
    public static class MockSavingsAccountRepository
    {
        public static Mock<IRepositoryAsync<SavingsAccount>> GetSavingsAccountRepository()
        {
            throw new NotImplementedException();
        }
    }
}
