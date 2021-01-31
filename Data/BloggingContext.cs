using dotnetcore_mvc_postgresql_linux.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetcore_mvc_postgresql_linux.Data
{
    public class BloggingContext: DbContext
    {
  /*          public BloggingContext()
            {
            }
*/

            public BloggingContext(DbContextOptions<BloggingContext> options) : base (options)
            {}
            public DbSet<Article> Articles { get; set; }
    }
}