using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using OnSale.Model.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnSale.Server.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
#pragma warning disable EF1001 // Internal EF Core API usage.
            if (!_context.Countries.Any())
#pragma warning restore EF1001 // Internal EF Core API usage.
            {
                _context.Countries.Add(new Country
                {
                    Name = "Dominican Republic",
                    Departments = new List<Department>
                {
                    new Department
                    {
                        Name = "Distrito Nacional",
                        Cities = new List<City>
                        {
                            new City { Name = "Santo Domingo Este" },
                            new City { Name = "Santo Domingo Oeste" },
                            new City { Name = "Santo Domingo Norte" }
                        }
                    },
                    new Department
                    {
                        Name = "San Juan",
                        Cities = new List<City>
                        {
                            new City { Name = "EL Cercado" }
                        }
                    },
                    new Department
                    {
                        Name = "Santiago",
                        Cities = new List<City>
                        {
                            new City { Name = "Cien Fuego" },
                            new City { Name = "Gurabo" },
                            new City { Name = "Los Cerros" }
                        }
                    }
                }
                });
                _context.Countries.Add(new Country
                {
                    Name = "USA",
                    Departments = new List<Department>
                {
                    new Department
                    {
                        Name = "California",
                        Cities = new List<City>
                        {
                            new City { Name = "Los Angeles" },
                            new City { Name = "San Diego" },
                            new City { Name = "San Francisco" }
                        }
                    },
                    new Department
                    {
                        Name = "Illinois",
                        Cities = new List<City>
                        {
                            new City { Name = "Chicago" },
                            new City { Name = "Springfield" }
                        }
                    }
                }
                });
                await _context.SaveChangesAsync();
            }
        }
    }

}
