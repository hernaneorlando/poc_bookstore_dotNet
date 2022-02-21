using Bs.Gateway.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bs.Gateway
{
    internal class SqlDataContext : DbContext
    {
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<PublisherEntity> Publishers { get; set; }

        public SqlDataContext(DbContextOptions<SqlDataContext> options) : base(options)
        {
            ChangeTracker.Tracked += (s, e) =>
            {
                if (e.FromQuery)
                {
                    FixDateTime(e);
                }
            };
        }

        private void FixDateTime(object entity)
        {
            var dateTimeProperties = entity
                .GetType()
                .GetProperties()
                .Where(p => p.PropertyType == typeof(DateTime) || p.PropertyType == typeof(DateTime?));

            if (dateTimeProperties.Any())
            {
                foreach (var property in dateTimeProperties)
                {
                    var dateTimeValue = property.GetValue(entity) as DateTime?;
                    if (dateTimeValue.HasValue && dateTimeValue.Value != default && dateTimeValue.Value.Kind == DateTimeKind.Unspecified)
                    {
                        property.SetValue(entity, DateTime.SpecifyKind(dateTimeValue.Value, DateTimeKind.Utc));
                    }
                }
            }
        }
    }
}