using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DotNextDemo.Configuration;
using DotNextDemo.Web;

namespace DotNextDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DotNextDemoDbContextFactory : IDesignTimeDbContextFactory<DotNextDemoDbContext>
    {
        public DotNextDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DotNextDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DotNextDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DotNextDemoConsts.ConnectionStringName));

            return new DotNextDemoDbContext(builder.Options);
        }
    }
}
