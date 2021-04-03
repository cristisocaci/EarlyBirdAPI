﻿using BCrypt.Net;
using EarlyBird.DataAccess.Entities;
using EarlyBird.DataAccess.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EarlyBird.DataAccess
{
    public class EarlyBirdContext : DbContext
    {
        public EarlyBirdContext(DbContextOptions<EarlyBirdContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<OfferEntity> Offers { get; set; }
        public DbSet<ReviewEntity> Reviews { get; set; }
        public DbSet<LocationEntity> Locations { get; set; }
        public DbSet<OfferCategoryEntity> OfferCategories { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OfferEntity>()
                .HasOne<UserEntity>(o => o.Publisher)
                .WithMany(u => u.OffersPublished)
                .HasForeignKey(o => o.PublisherId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OfferEntity>()
                .HasOne<UserEntity>(o => o.Accepter)
                .WithMany(u => u.OffersAccepted)
                .HasForeignKey(o => o.AccepterId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ReviewEntity>()
                 .HasOne<UserEntity>(r => r.Receiver)
                 .WithMany(u => u.ReviewsReceived)
                 .HasForeignKey(r => r.ReceiverId)
                 .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ReviewEntity>()
                 .HasOne<UserEntity>(r => r.Sender)
                 .WithMany(u => u.ReviewsSent)
                 .HasForeignKey(r => r.SenderId)
                 .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<OfferCategoryEntity>()
                 .HasOne<CategoryEntity>(oc => oc.Category)
                 .WithMany(c => c.Offers)
                 .HasForeignKey(oc => oc.CategoryId)
                 .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OfferCategoryEntity>()
                 .HasOne<OfferEntity>(oc => oc.Offer)
                 .WithMany(o => o.Categories)
                 .HasForeignKey(oc => oc.OfferId)
                 .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserEntity>().HasData(SeedUsers());
        }

        #region private methods
        private IEnumerable<UserEntity> SeedUsers()
        {
            var users = new List<UserEntity>();
            var salt1 = BCrypt.Net.BCrypt.GenerateSalt();
            users.Add(new UserEntity
            {
                Id = Guid.Parse("07d94746-c113-4de6-a0bf-8c4789b51c67"),
                Username = "admin",
                Salt = salt1,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin" + salt1),
                Role = Roles.Admin
            });

            var salt2 = BCrypt.Net.BCrypt.GenerateSalt();
            users.Add(new UserEntity
            {
                Id = Guid.Parse("6ac15295-fffe-49a8-aaaf-cca3255e9bb0"),
                Username = "worker",
                Salt = salt2,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("worker" + salt2),
                Role = Roles.Worker
            });

            var salt3 = BCrypt.Net.BCrypt.GenerateSalt();
            users.Add(new UserEntity
            {
                Id = Guid.Parse("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                Username = "publisher",
                Salt = salt3,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("publisher" + salt3),
                Role = Roles.Publisher
            });
            var salt4 = BCrypt.Net.BCrypt.GenerateSalt();
            users.Add(new UserEntity
            {
                Id = Guid.Parse("1545516d-abe8-4597-96a4-7998e8c51c79"),
                Username = "publisher2",
                Salt = salt4,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("publisher" + salt4),
                Role = Roles.Publisher
            });
            var salt5 = BCrypt.Net.BCrypt.GenerateSalt();
            users.Add(new UserEntity
            {
                Id = Guid.Parse("d935c8e9-ab96-4ae9-a7b3-6c6e6ec384c5"),
                Username = "worker2",
                Salt = salt5,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("worker" + salt5),
                Role = Roles.Worker
            });

            return users;
        }
        #endregion


    }
}