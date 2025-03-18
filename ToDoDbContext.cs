// using System;
// using System.Collections.Generic;
// using Microsoft.EntityFrameworkCore;
// using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

// namespace TodoApi;

// public partial class ToDoDbContext : DbContext
// {
//     public ToDoDbContext()
//     {
//     }

//     // public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
//     //     : base(options)
//     // {
//     // }

//     // public virtual DbSet<Item> Items { get; set; }

//     // public virtual DbSet<User> Users { get; set; }

//     public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options) { }

//     public DbSet<User> Users { get; set; }
//     public DbSet<Item> Items { get; set; }


//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         => optionsBuilder.UseMySql("name=ToDoDB", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.41-mysql"));

//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         modelBuilder
//             .UseCollation("utf8mb4_0900_ai_ci")
//             .HasCharSet("utf8mb4");

//         modelBuilder.Entity<Item>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PRIMARY");

//             entity.ToTable("items");

//             entity.Property(e => e.IsComplete).HasColumnType("tinyint(1)");
//             entity.Property(e => e.NameT).HasMaxLength(100);
//             entity.Property(e => e.UserId).HasColumnName("userId");
//         });

//         modelBuilder.Entity<User>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PRIMARY");

//             entity.ToTable("users");

//             entity.Property(e => e.Id).HasColumnName("id");
//             entity.Property(e => e.Name)
//                 .HasMaxLength(30)
//                 .HasColumnName("name");
//             entity.Property(e => e.Password)
//                 .HasMaxLength(20)
//                 .HasColumnName("password");
//         });

//         OnModelCreatingPartial(modelBuilder);
//     }

//     partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
// }

// using Microsoft.EntityFrameworkCore;

// namespace TodoApi
// {
//     public partial class ToDoDbContext : DbContext
//     {
//         public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options) { }

//         public DbSet<User> Users { get; set; }
//         public DbSet<Item> Items { get; set; }

//         protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             modelBuilder.Entity<Item>(entity =>
//             {
//                 entity.HasKey(e => e.Id).HasName("PRIMARY");

//                 entity.ToTable("items");

//                 entity.Property(e => e.IsComplete).HasColumnType("tinyint(1)");
//                 entity.Property(e => e.NameT).HasMaxLength(100);
//                 entity.Property(e => e.UserId).HasColumnName("userId");
//             });

//             modelBuilder.Entity<User>(entity =>
//             {
//                 entity.HasKey(e => e.Id).HasName("PRIMARY");

//                 entity.ToTable("users");

//                 entity.Property(e => e.Id).HasColumnName("id");
//                 entity.Property(e => e.Name)
//                     .HasMaxLength(30)
//                     .HasColumnName("Name");
//                 entity.Property(e => e.Password)
//                     .HasMaxLength(20)
//                     .HasColumnName("Password");
//             });

//             OnModelCreatingPartial(modelBuilder);
//         }

//         partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//     }
// }


using Microsoft.EntityFrameworkCore;

namespace TodoApi
{
    public partial class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("Items");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.NameT).HasColumnName("Name").HasMaxLength(45);
                entity.Property(e => e.IsComplete).HasColumnName("IsComplete").HasColumnType("tinyint(1)");
                entity.Property(e => e.UserId).HasColumnName("UserId");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("Users");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("Name").HasMaxLength(45);
                entity.Property(e => e.Password).HasColumnName("Password").HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}