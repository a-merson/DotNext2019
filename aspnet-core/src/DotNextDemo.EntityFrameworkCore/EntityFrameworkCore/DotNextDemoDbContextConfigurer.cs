using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DotNextDemo.EntityFrameworkCore
{
    public static class DotNextDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DotNextDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DotNextDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
