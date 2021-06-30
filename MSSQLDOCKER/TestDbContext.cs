using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MSSQLDOCKER
{
    public class TestDbContext: DbContext
    {
        public DbSet<TestEntry> TestEntries { get; set; }
        public TestDbContext(DbContextOptions<TestDbContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestEntry>()
                .ToContainer("test2");
            modelBuilder.Entity<TestEntry>().HasData(new TestEntry() { Id = new Guid("a2d37637-94bd-41b5-b61d-6ca29e5a7e0d"), testText = "seededdata" });

        }


    }
}
