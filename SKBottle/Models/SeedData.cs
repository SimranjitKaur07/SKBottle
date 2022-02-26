using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SKBottle.Data;
using System;
using System.Linq;

namespace SKBottle.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SKBottleContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SKBottleContext>>()))
            {
                // Look for any movies.
                if (context.Bottle.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bottle.AddRange(
                    new Bottle
                    {
                        Shape = "Square",
                        Brand = "Cello",
                        Capacity = 5,
                        Color = "Black",
                        Material = "Steel",
                        Rating = 5
                    },
                                         new Bottle
                                         {
                                             Shape = "Cylinder",
                                             Brand = "Vapour",
                                             Capacity = 4,
                                             Color = "Red",
                                             Material = "Aluminum",
                                             Rating = 3
                                         },

                      new Bottle
                      {
                          Shape = "Circle",
                          Brand = "Milton",
                          Capacity = 10,
                          Color = "Silver",
                          Material = "Steel",
                          Rating = 8
                      },
                       new Bottle
                       {
                           Shape = "Round",
                           Brand = "Polo",
                           Capacity = 7,
                           Color = "Pink",
                           Material = "Glass",
                           Rating = 7
                       },
                        new Bottle
                        {
                            Shape = "Square",
                            Brand = "Nestle",
                            Capacity = 8,
                            Color = "Green",
                            Material = "Steel",
                            Rating = 7
                        },
                         new Bottle
                         {
                             Shape = "Cylinder",
                             Brand = "Life Bottle",
                             Capacity = 4,
                             Color = "Blue",
                             Material = "Copper",
                             Rating = 9
                         },
                          new Bottle
                          {
                              Shape = "Circle",
                              Brand = "Highland Spring",
                              Capacity = 16,
                              Color = "Brown",
                              Material = "Plastic",
                              Rating = 10
                          },
                           new Bottle
                           {
                               Shape = "Round",
                               Brand = "Ice Mountain",
                               Capacity = 18,
                               Color = "Yellow",
                               Material = "Plastic",
                               Rating = 10
                           },
                            new Bottle
                            {
                                Shape = "Cylinder",
                                Brand = "ADS Bottle",
                                Capacity = 8,
                                Color = "White",
                                Material = "Aluminum",
                                Rating = 3
                            }

                );
                context.SaveChanges();
            }
        }
    }
}