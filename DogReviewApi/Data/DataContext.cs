using DogReviewApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DogReviewApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Dog> Dog { get; set; }
        public DbSet<DogOwner> DogOwners { get; set; }
        public DbSet<DogCategory> DogCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DogCategory>()
                .HasKey(dc => new { dc.DogId, dc.CategoryId });
            modelBuilder.Entity<DogCategory>()
                .HasOne(d => d.Dog)
                .WithMany(dc => dc.DogCategories)
                .HasForeignKey(c => c.DogId);
            modelBuilder.Entity<DogCategory>()
                .HasOne(d => d.Category)
                .WithMany(dc => dc.DogCategories)
                .HasForeignKey(c => c.CategoryId);
            ////////////////////////////////////////
            modelBuilder.Entity<DogOwner>()
                .HasKey(dw => new { dw.DogId, dw.OwnerId });
            modelBuilder.Entity<DogOwner>()
                .HasOne(d => d.Dog)
                .WithMany(dw => dw.DogOwners)
                .HasForeignKey(w => w.DogId);
            modelBuilder.Entity<DogOwner>()
                .HasOne(d => d.Owner)
                .WithMany(dw => dw.DogOwners)
                .HasForeignKey(w => w.OwnerId);



        }

    }
}
