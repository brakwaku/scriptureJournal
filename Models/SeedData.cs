using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
// using RazorPagesScripture.Data;
using System;
using System.Linq;

namespace RazorPagesScripture.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesScriptureContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesScriptureContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        ScriptureRef = "Matthew 3:24",
                        DateEntered = DateTime.Parse("2021-2-12"),
                        Note = "Some notes"
                    },

                    new Scripture
                    {
                        ScriptureRef = "Galatians 5:15 ",
                        DateEntered = DateTime.Parse("2021-2-12"),
                        Note = "Other notes"
                    },

                    new Scripture
                    {
                        ScriptureRef = "2 Nephi 3:7",
                        DateEntered = DateTime.Parse("2021-2-12"),
                        Note = "Some notes"
                    },

                    new Scripture
                    {
                        ScriptureRef = "D&C 4",
                        DateEntered = DateTime.Parse("2021-2-12"),
                        Note = "Other notes"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}