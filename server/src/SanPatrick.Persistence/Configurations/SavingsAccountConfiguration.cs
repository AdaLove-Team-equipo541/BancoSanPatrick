using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanPatrick.Domain.Entities;

namespace SanPatrick.Persistence.Configurations
{
    public class SavingsAccountConfiguration : IEntityTypeConfiguration<SavingsAccount>
    {
        public void Configure(EntityTypeBuilder<SavingsAccount> builder)
        {
            builder.ToTable("savings_account");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Alias)
                .HasMaxLength(30);
        }
    }
}
