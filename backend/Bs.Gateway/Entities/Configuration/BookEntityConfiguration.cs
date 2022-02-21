using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bs.Gateway.Entities.Configuration
{
    internal class BookEntityConfiguration : IEntityTypeConfiguration<BookEntity>
    {
        public void Configure(EntityTypeBuilder<BookEntity> builder)
        {
            builder.ToTable("Books").HasKey(e => e.Id);

            builder.Property(e => e.Title).IsRequired();
            builder.Property(e => e.ISBN).IsRequired();

            builder.HasOne(e => e.Publisher);
            builder.HasMany(e => e.Authors);
        }
    }
}