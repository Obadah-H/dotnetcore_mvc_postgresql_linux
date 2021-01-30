using System;
using Microsoft.EntityFrameworkCore;
namespace dotnetcore_mvc_postgresql_linux.Models
{
    public class DataContext: DbContext
    {
         public DataContext()
    {
    }

        public DataContext(DbContextOptions options) : base (options)
        {}

        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {}
        public DbSet<Articles> Articles {get;set;}

    }
}
