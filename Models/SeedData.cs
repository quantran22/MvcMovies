using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using _1721050358;
using _1721050358.Models;

namespace _1721050358.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DemoDBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DemoDBContext>>()))
            {
                //Look for any Person.
                if (context.Person.Any())
                {
                    return;   // DB has been seeded
                }

                context.Person.AddRange(
                    new Person
                    {
                        PersonId = 001,
                        PersonName = "Person01",
                       
                    },

                    new Person
                    {
                        PersonId = 002,
                        PersonName = "Person02",
                       
                    },

                    new Person
                    {
                        PersonId = 003,
                        PersonName = "Person03",
                    },

                    new Person
                    {
                        PersonId = 004,
                        PersonName = "Person04",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}