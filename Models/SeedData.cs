
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProCleaner.Data;
using System;
using System.Linq;

namespace ProCleaner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProCleanerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProCleanerContext>>()))
            {
                // Look for any movies.
                if (context.Machine.Any())
                {
                    return;   // DB has been seeded
                }

                context.Machine.AddRange(
                    new Machine
                    {
                        Brand = "Brand 1",
                        Capacity = "1 cubic feet",
                        Color = "White",
                        Material = "Steel",
                        Weight = 4,
                        Price = 59.99M,
                        Rating = 2.5M
                    },
                    new Machine
                    {
                        Brand = "Brand 1",
                        Capacity = "1 cubic feet",
                        Color = "White",
                        Material = "Steel",
                        Weight = 4,
                        Price = 59.99M,
                        Rating = 2.5M
                    },
                    new Machine
                    {
                        Brand = "Brand 1",
                        Capacity = "1 cubic feet",
                        Color = "White",
                        Material = "Steel",
                        Weight = 4,
                        Price = 59.99M,
                        Rating = 2.5M
                    },
                    new Machine
                    {
                        Brand = "Brand 1",
                        Capacity = "1 cubic feet",
                        Color = "White",
                        Material = "Steel",
                        Weight = 4,
                        Price = 59.99M,
                        Rating = 2.5M
                    },
                    new Machine
                    {
                        Brand = "Brand 1",
                        Capacity = "1 cubic feet",
                        Color = "White",
                        Material = "Steel",
                        Weight = 4,
                        Price = 59.99M,
                        Rating = 2.5M
                    },
                    new Machine
                    {
                        Brand = "Brand 1",
                        Capacity = "1 cubic feet",
                        Color = "White",
                        Material = "Steel",
                        Weight = 4,
                        Price = 59.99M,
                        Rating = 2.5M
                    },
                    new Machine
                    {
                        Brand = "Brand 1",
                        Capacity = "1 cubic feet",
                        Color = "White",
                        Material = "Steel",
                        Weight = 4,
                        Price = 59.99M,
                        Rating = 2.5M
                    },
                    new Machine
                    {
                        Brand = "Brand 1",
                        Capacity = "1 cubic feet",
                        Color = "White",
                        Material = "Steel",
                        Weight = 4,
                        Price = 59.99M,
                        Rating = 2.5M
                    },
                    new Machine
                    {
                        Brand = "Brand 1",
                        Capacity = "1 cubic feet",
                        Color = "White",
                        Material = "Steel",
                        Weight = 4,
                        Price = 59.99M,
                        Rating = 2.5M
                    },
                    new Machine
                    {
                        Brand = "Brand 1",
                        Capacity = "1 cubic feet",
                        Color = "White",
                        Material = "Steel",
                        Weight = 4,
                        Price = 59.99M,
                        Rating = 2.5M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}