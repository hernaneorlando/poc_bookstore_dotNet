using Bs.Domain.Services;
using Bs.Domain.Services.Implementation;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddDomainDependencies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<IBookService, BookService>();
        }
    }
}