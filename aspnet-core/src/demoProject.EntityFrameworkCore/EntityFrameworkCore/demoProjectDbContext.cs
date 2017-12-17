using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using demoProject.Authorization.Roles;
using demoProject.Authorization.Users;
using demoProject.MultiTenancy;
using demoProject.Models;

namespace demoProject.EntityFrameworkCore
{
    public class demoProjectDbContext : AbpZeroDbContext<Tenant, Role, User, demoProjectDbContext>
    {
        /* Define an IDbSet for each entity of the application */

        public DbSet<Product> Products { get; set; }
        public demoProjectDbContext(DbContextOptions<demoProjectDbContext> options)
            : base(options)
        {
        }
    }
}
