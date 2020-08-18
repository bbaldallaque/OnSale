using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using OnSale.Common.Enums;
using OnSale.Model.Entities;
using OnSale.Server.Data.Entities;
using OnSale.Server.Infraestructure.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Server.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }


        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
            await CheckRolesAsync();
            await CheckUserAsync("223-0035346-7", "Bryant", "Baldallaque", "dr_baldallaque@hotmail.com", "809-855-8581", "c/ 10 #20 Cacique III D.N", UserType.Admin);

        }

        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());
        }

        private async Task<User> CheckUserAsync(
            string document,
            string firstName,
            string lastName,
            string email,
            string phone,
            string address,
            UserType userType)
        {
            User user = await _userHelper.GetUserAsync(email);
            if (user == null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    Address = address,
                    Document = document,
                    City = _context.Cities.FirstOrDefault(),
                    UserType = userType
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());
            }

            return user;
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
