﻿using EarlyBird.DataAccess.Entities;
using EarlyBird.DataAccess.Utils;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

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
        public DbSet<ConversationEntity> Conversations { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }

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
                .IsRequired(false)
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

            //if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            //{
            //    modelBuilder.Entity<UserEntity>().HasData(SeedUsers());
            //    modelBuilder.Entity<CategoryEntity>().HasData(GetSeedData<CategoryEntity>("CategorySeed.json"));
            //    modelBuilder.Entity<LocationEntity>().HasData(GetSeedData<LocationEntity>("LocationSeed.json"));
            //    modelBuilder.Entity<OfferEntity>().HasData(GetSeedData<OfferEntity>("OfferSeed.json"));
            //    modelBuilder.Entity<OfferCategoryEntity>().HasData(GetSeedData<OfferCategoryEntity>("OfferCategorySeed.json"));
            //    modelBuilder.Entity<ReviewEntity>().HasData(GetSeedData<ReviewEntity>("ReviewSeed.json"));
            //}
        }

        #region private methods

        private IEnumerable<T> GetSeedData<T>(string file)
        {
            string basePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", ".."));
            string relativePath = Path.Combine("EarlyBird.DataAccess", "Utils", "Seeds");
            string fullPath = Path.Combine(basePath, relativePath, file);
            using ( StreamReader sr = new StreamReader(fullPath))
            {
                string json = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<List<T>>(json);
            }
        }

        private IEnumerable<UserEntity> SeedUsers()
        {
            var users = new List<UserEntity>();
            var salt = BCrypt.Net.BCrypt.GenerateSalt();
            var username = Environment.GetEnvironmentVariable("ADMIN_USERNAME");
            var password = Environment.GetEnvironmentVariable("ADMIN_PASSWORD");
            users.Add(new UserEntity
            {
                Id = Guid.Parse("07d94746-c113-4de6-a0bf-8c4789b51c67"),
                Username = username,
                Firstname = "Admin",
                Lastname = "EarlyBird",
                Salt = salt,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password + salt),
                Role = Roles.Admin
            });

            var salt2 = BCrypt.Net.BCrypt.GenerateSalt();
            users.Add(new UserEntity
            {
                Id = Guid.Parse("6ac15295-fffe-49a8-aaaf-cca3255e9bb0"),
                Username = "worker",
                Firstname = "Andrei",
                Lastname = "Varga",
                Salt = salt2,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("worker" + salt2),
                Role = Roles.Worker
            });

            var salt3 = BCrypt.Net.BCrypt.GenerateSalt();
            users.Add(new UserEntity
            {
                Id = Guid.Parse("3a779cd5-acf9-44be-b1c9-342f5edc88cb"),
                Username = "publisher",
                Firstname = "Andrei-Vlad",
                Lastname = "Popica",
                Salt = salt3,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("publisher" + salt3),
                Role = Roles.Publisher
            });
            var salt4 = BCrypt.Net.BCrypt.GenerateSalt();
            users.Add(new UserEntity
            {
                Id = Guid.Parse("1545516d-abe8-4597-96a4-7998e8c51c79"),
                Username = "publisher2",
                Firstname = "Marius-Cristian",
                Lastname = "Socaci",
                Salt = salt4,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("publisher" + salt4),
                Role = Roles.Publisher
            });
            var salt5 = BCrypt.Net.BCrypt.GenerateSalt();
            users.Add(new UserEntity
            {
                Id = Guid.Parse("d935c8e9-ab96-4ae9-a7b3-6c6e6ec384c5"),
                Username = "worker2",
                Firstname = "Flaviu",
                Lastname = "Raita",
                Salt = salt5,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("worker" + salt5),
                Role = Roles.Worker
            });

            return users;
        }

        #endregion


    }
}
