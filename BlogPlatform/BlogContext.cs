using BlogPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform
{
    public class BlogContext : DbContext
    {
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Content> Contents { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb; Database=BlogDB01016; Trusted_Connection=True";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            // seed data

            modelbuilder.Entity<Content>().HasData(
                new Content() { Id = 1, Tytle = "Sport Cars", Body = "Sport cars are fast", CategoryId = 1, time = new DateTime(2021, 10, 13), Author = "author1" },
                 new Content() { Id = 2, Tytle = "Offroad Cars", Body = "Offroad cars can go anyware", CategoryId = 1, time = new DateTime(2021, 10, 11), Author = "author3" },
                    new Content() { Id = 3, Tytle = "Sport activities", Body = "It is important for helthy life", CategoryId = 2, time = new DateTime(2021, 9, 13), Author = "author3" },
                  new Content() { Id = 4, Tytle = "Profesional Sport", Body = "To do sport proffesionaly is hard and take a lots of time", CategoryId = 2, time = new DateTime(2021, 9, 13), Author = "author2" },
                   new Content() { Id = 5, Tytle = "Healty food", Body = "Healthy food is important part of healty life", CategoryId = 3, time = new DateTime(2021, 8, 13), Author = "author2" },
                    new Content() { Id = 6, Tytle = "fast food", Body = "Is cheap and fast way to have a meal but  unhealty", CategoryId = 3, time = new DateTime(2021, 8, 13), Author = "author1" }

                );

            modelbuilder.Entity<Category>().HasData(
               new Category() { Id = 1, Name = "Cars" },
               new Category() { Id = 2, Name = "Sport" },
               new Category() { Id = 3, Name = "Food" }

               );

            base.OnModelCreating(modelbuilder);
        }
    }

}