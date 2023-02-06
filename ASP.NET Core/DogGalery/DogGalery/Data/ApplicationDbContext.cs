using DogGalery.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DogGalery.Models;

namespace DogGalery.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<DogGalery.Models.DogEditViewModel> DogEditViewModel { get; set; }
        public DbSet<DogGalery.Models.DogDeleteViewModel> DogDeleteViewModel { get; set; }
        public DbSet<DogGalery.Models.DogDetailsViewModel> DogDetailsViewModel { get; set; }
        public DbSet<DogGalery.Models.DogAllViewModel> DogAllViewModel { get; set; }
    }
}
