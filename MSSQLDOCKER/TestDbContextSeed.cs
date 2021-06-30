using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MSSQLDOCKER
{
    public static class TestDbContextSeed
    {
        public static async Task SeedData(IServiceProvider serviceProvider)
        {
            using (var context = new TestDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<TestDbContext>>()))
            {
                //context.Database.Migrate();
                //if (await context.TestEntries.AnyAsync()) 
                //    return; 
                ////if(context.TestEntries.Any()) return;
                //await context.TestEntries.AddAsync(new TestEntry() {testText = "testseed"});
                //await context.SaveChangesAsync();
            }
        }
    }
}
