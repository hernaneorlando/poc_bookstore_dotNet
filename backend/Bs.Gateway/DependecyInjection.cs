using Bs.Gateway;
using Bs.Gateway.Repositories;
using Bs.Gateway.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddGatewayDependencies(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var dbConnections = configuration.GetSection("DatabaseConnection");
            serviceCollection.AddDbContext<SqlDataContext>(options =>
            {
                options.UseSqlServer(dbConnections["SqlConnectionString"]);
            });

            serviceCollection.AddTransient<NoSqlDataContext>(provider =>
            {
                var settings = MongoClientSettings.FromConnectionString(dbConnections["NoSqlConnectionString"]);
                settings.ServerApi = new ServerApi(ServerApiVersion.V1);
                return new NoSqlDataContext(settings);
            });

            serviceCollection.AddTransient<IUserRepository, UserRepository>();
            serviceCollection.AddTransient<IBookRepository, BookRepository>();
        }

        public static void EnsureDbMigration(this IServiceProvider serviceProvider)
        {
            var sqlDataContext = serviceProvider.GetRequiredService<SqlDataContext>();
            sqlDataContext.Database.Migrate();
        }
    }
}