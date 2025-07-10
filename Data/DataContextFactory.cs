using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_бухгалтерия.Data
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
       public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=micros_test_task;Username=postgres;Password=jalol;");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
