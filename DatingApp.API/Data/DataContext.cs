using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        public DbSet<Value> Values {get; set; } //The name of this will be the name of the SQL table when it is created.
        public DbSet<User> Users { get; set; }
    }
}