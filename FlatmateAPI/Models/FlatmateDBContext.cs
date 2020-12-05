using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace FlatmateAPI.Models
{
    public class FlatmateDBContext : DbContext
    {
        public FlatmateDBContext(DbContextOptions<FlatmateDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<GroceryList>().HasMany(gl => gl.Items);
            modelBuilder.Entity<Item>().HasMany(i => i.Stores);
            modelBuilder.Entity<User>().HasMany(u => u.OwnedHouses).WithOne(oh => oh.Owner);
            modelBuilder.Entity<User>().HasMany(u => u.Houses).WithMany(h => h.Users);
            modelBuilder.Entity<House>().HasMany(u => u.Users).WithMany(h => h.Houses);

            modelBuilder.Entity<Post>().HasMany(p => p.Comments);
            //modelBuilder.Entity<Duty>().HasOne(d => d.DutyCreator);
            //modelBuilder.Entity<UserInvitation>().HasKey(o => new { o.UserId, o.HouseId });
            

            //modelBuilder.Entity<UserHouse>().HasOne(o => o.House );
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<GroceryList> Lists { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Duty> Duties { get; set; }
        public DbSet<DutyType> DutyTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInvitation> UserInvitation { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
