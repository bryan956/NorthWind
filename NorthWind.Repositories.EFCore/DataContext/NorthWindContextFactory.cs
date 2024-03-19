using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Design.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Repositories.EFCore.DataContext
{
    internal class NorthWindContextFactory : IDesignTimeDbContextFactory<NorthWindContext>
    {
        public NorthWindContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = 
                new DbContextOptionsBuilder<NorthWindContext>();
            OptionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssgllocaldb;database=NorthWindDB");
            return new NorthWindContext(OptionsBuilder.Options);

        }
    }
}
