using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FlatmateAPI.Models
{
    public partial class FlatmateDBContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<ListItem> ListItems { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserHouse> UsersHouses { get; set; }

       


    }
}
