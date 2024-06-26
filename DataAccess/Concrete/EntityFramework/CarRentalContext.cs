﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarRentalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DbReCapProject;Trusted_Connection=true");

        }

        public DbSet<Car> tblCars { get; set; }
        public DbSet<Color> tblColors{ get; set; }
        public DbSet<Brand> tblBrands { get; set; }

        public DbSet<Rental> tblRentals { get; set;}

        public DbSet<Customer> tblCustomers { get; set; }

        public DbSet<User> tblUsers { get; set; }
        public DbSet<CarImage> tblCarImages { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    }
}


