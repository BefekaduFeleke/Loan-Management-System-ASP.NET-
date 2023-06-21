using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LoanManagementDone.Models
{
    public partial class LoanManagementSystemlContext : DbContext
    {
        public LoanManagementSystemlContext()
        {
        }

        public LoanManagementSystemlContext(DbContextOptions<LoanManagementSystemlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LoanApplication> LoanApplications { get; set; }

        public virtual DbSet<LoanType> LoanTypes { get; set; }
        public virtual DbSet<Surety> Sureties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=LoanManagementSystem;Integrated Security= True;Pooling =False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdIssuedDate).HasColumnType("date");

                entity.Property(e => e.IdNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Income).HasColumnType("money");

                entity.Property(e => e.IncomeProofPhoto).HasColumnType("image");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNumberOne)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumberTwo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProfilePicture)
                    .HasColumnType("image")
                    .HasColumnName("profile_picture");

                entity.Property(e => e.Rating).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.Surety)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.SuretyId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Customers__Suret__145C0A3F");
            });

            modelBuilder.Entity<LoanApplication>(entity =>
            {
                entity.ToTable("LoanApplication");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.LoanAmount)
                    .HasColumnType("money")
                    .HasColumnName("loan_amount");

                entity.Property(e => e.LoanApplicationApprovedDate).HasColumnType("date");

                entity.Property(e => e.LoanApplicationSubmissionDate).HasColumnType("date");

                entity.Property(e => e.LoanControlNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LoanStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("loan_status");

                entity.Property(e => e.Purpose)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("purpose");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.LoanApplications)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__LoanAppli__Custo__173876EA");

                entity.HasOne(d => d.LoanType)
                    .WithMany(p => p.LoanApplications)
                    .HasForeignKey(d => d.LoanTypeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__LoanAppli__LoanT__182C9B23");
            });



            modelBuilder.Entity<LoanType>(entity =>
            {
                entity.ToTable("LoanType");

                entity.Property(e => e.LoanDescription)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDuration)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("loan_duration");

                entity.Property(e => e.LoanName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaximumAmount).HasColumnType("money");

                entity.Property(e => e.MinimunAmount).HasColumnType("money");

                entity.Property(e => e.ServiceCharge).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Surety>(entity =>
            {
                entity.ToTable("Surety");

                entity.Property(e => e.SuretyId).HasColumnName("SuretyID");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdIssuedDate).HasColumnType("date");

                entity.Property(e => e.IdNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Income).HasColumnType("money");

                entity.Property(e => e.IncomeProofPhoto).HasColumnType("image");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumberOne)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumberTwo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProfilePicture)
                    .HasColumnType("image")
                    .HasColumnName("profile_picture");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
