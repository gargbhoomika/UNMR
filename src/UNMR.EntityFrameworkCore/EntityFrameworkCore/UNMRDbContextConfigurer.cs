using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace UNMR.EntityFrameworkCore
{
    public static class UNMRDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<UNMRDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<UNMRDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
