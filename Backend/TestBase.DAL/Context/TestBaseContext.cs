using Microsoft.EntityFrameworkCore;
using TestBase.Common.Entities;

namespace TestBase.DAL.Context
{
    public class TestBaseContext : DbContext
    {
        public TestBaseContext(DbContextOptions<TestBaseContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Test> Tests { get; set; }
    }
}
