using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet1.Persistance
{
    public class Dotnet1Context : DbContext
    {
        public Dotnet1Context() { }
        public Dotnet1Context(DbContextOptions<Dotnet1Context> options) : base(options)
        { }

        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Profils> Profils { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=changeme");
    } 
}
