using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using demoProject.Configuration;
using demoProject.Web;

namespace demoProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class demoProjectDbContextFactory : IDesignTimeDbContextFactory<demoProjectDbContext>
    {
        public demoProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<demoProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            demoProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(demoProjectConsts.ConnectionStringName));

            return new demoProjectDbContext(builder.Options);
        }
    }
}
