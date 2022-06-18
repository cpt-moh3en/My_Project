using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Models;

namespace My_Project.Context
{
    public class My_ProjectContext : DbContext
    {
        public My_ProjectContext(DbContextOptions<My_ProjectContext> options) : base(options)
        {
        }

        public DbSet<Message_Tbl> Tbl_Message { get; set; }
        public DbSet<User_Tbl> Tbl_User { get; set; }

        // public class ToDoContextFactory : IDesignTimeDbContextFactory<My_ProjectContext>
        // {
        //     public My_ProjectContext CreateDbContext(string[] args)
        //     {
        //         var builder = new DbContextOptionsBuilder<My_ProjectContext>();
        //         builder.UseSqlServer("Data Source=.;initial Catalog=My_Project;integrated Security=SSPI;MultipleActiveResultSets=true");
        //         return new My_ProjectContext(builder.Options);
        //     }
        // }
    }
}