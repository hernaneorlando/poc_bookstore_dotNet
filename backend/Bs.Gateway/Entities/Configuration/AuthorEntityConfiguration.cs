using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bs.Gateway.Entities.Configuration
{
    internal class AuthorEntityConfiguration : IEntityTypeConfiguration<AuthorEntity>
    {
        public void Configure(EntityTypeBuilder<AuthorEntity> builder)
        {
            builder.ToTable("Authors").HasKey(e => e.Id);

            builder.Property(e => e.Name).IsRequired();
        }
    }
}