using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Домашняя_бухгалтерия.Models;

namespace Домашняя_бухгалтерия.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Transaction>()
                .HasOne(u => u.User)
                .WithMany(t => t.Transactions)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>()
                .HasOne(u => u.User)
                .WithMany(c => c.Categories)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        Id = 1,
                        Type = "Доход",
                        Name = "Заработная плата",
                    },
                    new Category
                    {
                        Id = 2,
                        Type = "Расход",
                        Name = "Продукты питания",
                    },
                    new Category
                    {
                        Id = 3,
                        Type = "Расход",
                        Name = "Транспорт",
                    },
                    new Category
                    {
                        Id = 4,
                        Type = "Расход",
                        Name = "Мобильная связь",
                    },
                    new Category
                    {
                        Id = 5,
                        Type = "Расход",
                        Name = "Интернет",
                    },
                    new Category
                    {
                        Id = 6,
                        Type = "Расход",
                        Name = "Развлечения",
                    }
                );
        }
    }
}
