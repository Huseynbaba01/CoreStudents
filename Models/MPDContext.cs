using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StudentsApplication.Models
{
    public partial class MPDContext : DbContext
    {
        public MPDContext()
        {
        }

        public MPDContext(DbContextOptions<MPDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MPD;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Degree)
                    .HasMaxLength(50)
                    .HasColumnName("DEGREE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
