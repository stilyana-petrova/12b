using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HotelWebApp.Entities;

namespace HotelWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<HotelWebApp.Entities.Room> Rooms { get; set; }
        public DbSet<HotelWebApp.Entities.Client> Clients { get; set; }
        public DbSet<HotelWebApp.Entities.Reservation> Reservations { get; set; }
    }
}
