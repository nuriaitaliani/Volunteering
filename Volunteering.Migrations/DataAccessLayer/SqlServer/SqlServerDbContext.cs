using Microsoft.EntityFrameworkCore;
using Volunteering.Migrations.Helper;

namespace Volunteering.Migrations.DataAccessLayer.SqlServer
{
    public class SqlServerDbContext : DbContextHelper
    {

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Common.Activities.GetTableDefinitions(builder);
            Common.Schedules.GetTableDefinitions(builder);
            Common.Users.GetTableDefinitions(builder);
            Common.UserSchedule.GetTableDefinitions(builder);        
        }
    }

    public class DevelopmentSqlServerDbContext : SqlServerDbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            System.IO.Directory.GetCurrentDirectory();

            options.UseSqlServer("Server = localhost,1433; Database = volunteering; User Id=sa; Password=qa1ws2ed34;",
                e => e.MigrationsHistoryTable("volunteering_migration"));
        }
    }

}
