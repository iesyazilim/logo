using System.Threading.Tasks;
using Ies.SampleApp.DepedencyResolvers.Microsoft;
using Ies.SampleApp.Items;
using Microsoft.Extensions.DependencyInjection;

namespace Ies.SampleApp.ConsoleUI
{
    class Program
    {
        static ServiceProvider resolver { get; } = CreateDI();

        static async Task Main(string[] args)
        {
            await ItemJobs();
        }

        static async Task ItemJobs()
        {
            var itemService = resolver.GetService<IItemService>();
            var itemList = await itemService.GetListAsync();
        }

        static ServiceProvider CreateDI()
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.Resolve();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
