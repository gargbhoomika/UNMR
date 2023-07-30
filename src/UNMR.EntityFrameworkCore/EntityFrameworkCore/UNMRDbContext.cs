using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using UNMR.Authorization.Roles;
using UNMR.Authorization.Users;
using UNMR.MultiTenancy;

namespace UNMR.EntityFrameworkCore
{
    public class UNMRDbContext : AbpZeroDbContext<Tenant, Role, User, UNMRDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public UNMRDbContext(DbContextOptions<UNMRDbContext> options)
            : base(options)
        {
        }
    }
}
