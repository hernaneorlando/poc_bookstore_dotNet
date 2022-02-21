using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bs.Gateway.Entities.Configuration
{
    internal class PublisherEntityConfiguration : IEntityTypeConfiguration<PublisherEntity>
    {
        public void Configure(EntityTypeBuilder<PublisherEntity> builder)
        {
            builder.ToTable("Publishers").HasKey(e => e.Id);
        }
    }
}