using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EntitiyFrameworkHoework.entities;
using EntitiyFrameworkHoework.configurations;

namespace EntitiyFrameworkHoework
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<Publisher> publishers { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BFCAF67;Database=library;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new authorConfiguration());
            modelBuilder.ApplyConfiguration(new publisherConfig());
            modelBuilder.ApplyConfiguration(new bookConfiguration());
        }
    }
}