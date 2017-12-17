using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace demoProject.EntityFrameworkCore
{
    public static class demoProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<demoProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<demoProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
