using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DOMAIN.DATABASE
{
    public partial class TEST_DATAContext : DbContext
    {
        public TEST_DATAContext()
        {
        }

        public TEST_DATAContext(DbContextOptions<TEST_DATAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=IT-EGP-06\\SQLEXPRESS;Database=TEST_DATA;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USER");

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(15)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .HasColumnName("PHONE");

                entity.Property(e => e.SecondName)
                    .HasMaxLength(50)
                    .HasColumnName("SECOND_NAME");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("USER_NAME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
