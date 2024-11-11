﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using libreria_JAGS.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace libreria_JAGS.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>()
                .HasOne(b => b.Book)
                .WithMany(ba => Book_Authors)
                .HasForeignKey(bi => bi.BookId);

            modelBuilder.Entity<Book_Author>()
                .HasOne(b => b.Author)
                .WithMany(ba => Book_Authors)
                .HasForeignKey(bi => bi.AuthorId);
            {

            }
        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book_Author> Book_Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

    }
}
