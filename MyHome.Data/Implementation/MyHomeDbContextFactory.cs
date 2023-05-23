using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Data.Implementation
{
    internal class MyHomeDbContextFactory : IDesignTimeDbContextFactory<MyHomeDbContext>
    {

        public MyHomeDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyHomeDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-MOGNFI4\\SQLEXPRESS;Database=MyHomeDb;Integrated Security=true;TrustServerCertificate=True");

            return new MyHomeDbContext(optionsBuilder.Options);

        }
    }
}
