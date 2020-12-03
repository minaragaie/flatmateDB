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

            modelBuilder.Entity<ListItem>().HasKey(o => new { o.ItemId, o.ListId });
            modelBuilder.Entity<StoreItem>().HasKey(o => new { o.ItemId, o.StoreId });
            modelBuilder.Entity<UserHouse>().HasKey(o => new { o.UserId, o.HouseId });
            //modelBuilder.Entity<UserHouse>().HasOne(o => o.House );
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<GroceryList> Lists { get; set; }
        public DbSet<ListItem> ListItems { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Duty> Duties { get; set; }
        public DbSet<DutyType> DutyTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserHouse> UsersHouses { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreItem> StoresItems { get; set; }
    }
}
