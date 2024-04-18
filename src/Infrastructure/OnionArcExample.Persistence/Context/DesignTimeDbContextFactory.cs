using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace OnionArcExample.Persistence.Context
{
    //public abstract class DesignTimeDbContextFactory<TContext> : IDesignTimeDbContextFactory<TContext> where TContext : DbContext
    //{
    //    protected abstract TContext CreateNewInstance(DbContextOptions<TContext> options);
    //    public TContext CreateDbContext(string[] args)
    //    {
    //        DbContextOptionsBuilder<TContext> builder = new DbContextOptionsBuilder<TContext>();
    //        IConfiguration configuration = new ConfigurationBuilder()
    //            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../OnionArcExample.WebAPI"))
    //            .AddJsonFile("appsettings.json")
    //            .Build();
    //        builder.UseSqlServer(configuration.GetConnectionString("SQLConnection"));
    //        return CreateNewInstance(builder.Options);
    //    }
    }
}
