using SanPatrick.Domain.Common;

namespace SanPatrick.Domain.Entities
{
    public class SavingsAccount : BaseEntity
    {
        public SavingsAccount()
        {
            Number = GenerateNumber();
        }
        public string Alias { get; set; } = string.Empty;
        public decimal Balance { get; set; } = 0;
        public string Number { get; private set; }

        private string GenerateNumber()
        {
            Random random = new Random();
            var num = random.NextInt64(1000000000, 9999999999);
            return num.ToString();
        }

        
    }
}
