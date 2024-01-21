using ApiExample.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiExample.Context
{
    public class ApiDBContext : DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options) : base(options){}

        public DbSet<User> users { get; set; }
    }
}
