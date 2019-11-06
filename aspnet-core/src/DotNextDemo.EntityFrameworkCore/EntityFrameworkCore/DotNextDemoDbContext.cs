using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DotNextDemo.Authorization.Roles;
using DotNextDemo.Authorization.Users;
using DotNextDemo.MultiTenancy;

namespace DotNextDemo.EntityFrameworkCore
{
    public class DotNextDemoDbContext : AbpZeroDbContext<Tenant, Role, User, DotNextDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DotNextDemoDbContext(DbContextOptions<DotNextDemoDbContext> options)
            : base(options)
        {
        }
    }
}
