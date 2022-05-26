using SanPatrick.Domain.Common;

namespace SanPatrick.Domain.Entities
{
    public class SavingsAccount : BaseEntity
    {
        public string Alias { get; set; }
        public decimal Balance { get; set; } = 0;
    }
}
