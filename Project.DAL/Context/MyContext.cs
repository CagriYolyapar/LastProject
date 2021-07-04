using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using Project.MAP.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Context
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new ShelfConfiguration());


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
