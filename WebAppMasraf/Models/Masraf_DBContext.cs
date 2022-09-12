using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppMasraf.Models
{
    public partial class Masraf_DBContext : DbContext
    {
        public Masraf_DBContext()
        {
        }

        public Masraf_DBContext(DbContextOptions<Masraf_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ConfigurationParameter> ConfigurationParameters { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<Expense> Expenses { get; set; } = null!;
        public virtual DbSet<ExpenseForm> ExpenseForms { get; set; } = null!;
        public virtual DbSet<ExpenseFormHistory> ExpenseFormHistories { get; set; } = null!;
        public virtual DbSet<ExpenseHistory> ExpenseHistories { get; set; } = null!;
        public virtual DbSet<ExpenseStatus> ExpenseStatuses { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<Resource> Resources { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
   optionsBuilder.UseSqlServer("Server=DESKTOP-QKRLM4G;Database=Masraf_DB;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConfigurationParameter>(entity =>
            {
                entity.HasKey(e => e.RId)
                    .HasName("PK__Configur__DE152E89B6E65D2F");

                entity.ToTable("ConfigurationParameter");

                entity.Property(e => e.RId).HasColumnName("R_ID");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK__Currency__A9FDEC12BED8C691");

                entity.ToTable("Currency");

                entity.Property(e => e.CId).HasColumnName("C_ID");

                entity.Property(e => e.UrCode)
                    .HasMaxLength(50)
                    .HasColumnName("Ur_Code");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasKey(e => e.ExpId)
                    .HasName("PK__Expense__3E4B0991E180024D");

                entity.ToTable("Expense");

                entity.Property(e => e.ExpId).HasColumnName("Exp_ID");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.ExpenseDate).HasColumnType("date");

                entity.Property(e => e.UExpenseFormId).HasColumnName("U_ExpenseFormID");

                entity.HasOne(d => d.UExpenseForm)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.UExpenseFormId)
                    .HasConstraintName("FK__Expense__U_Expen__31EC6D26");
            });

            modelBuilder.Entity<ExpenseForm>(entity =>
            {
                entity.HasKey(e => e.ExfId)
                    .HasName("PK__ExpenseF__E8D3A70B33CF3E5F");

                entity.ToTable("ExpenseForm");

                entity.Property(e => e.ExfId).HasColumnName("Exf_ID");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.UCurrencyId).HasColumnName("U_CurrencyID");

                entity.Property(e => e.UExpenseStatusId).HasColumnName("U_ExpenseStatusID");

                entity.Property(e => e.UUserId).HasColumnName("U_UserID");

                entity.HasOne(d => d.UCurrency)
                    .WithMany(p => p.ExpenseForms)
                    .HasForeignKey(d => d.UCurrencyId)
                    .HasConstraintName("FK__ExpenseFo__U_Cur__2F10007B");

                entity.HasOne(d => d.UExpenseStatus)
                    .WithMany(p => p.ExpenseForms)
                    .HasForeignKey(d => d.UExpenseStatusId)
                    .HasConstraintName("FK__ExpenseFo__U_Exp__2E1BDC42");

                entity.HasOne(d => d.UUser)
                    .WithMany(p => p.ExpenseForms)
                    .HasForeignKey(d => d.UUserId)
                    .HasConstraintName("FK__ExpenseFo__U_Use__2D27B809");
            });

            modelBuilder.Entity<ExpenseFormHistory>(entity =>
            {
                entity.HasKey(e => e.EfhId)
                    .HasName("PK__ExpenseF__6EEAF6C6C33F2EFF");

                entity.ToTable("ExpenseFormHistory");

                entity.Property(e => e.EfhId).HasColumnName("Efh_ID");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.UExpenseCurrencyId).HasColumnName("U_ExpenseCurrencyID");

                entity.Property(e => e.UExpenseFormId).HasColumnName("U_ExpenseFormID");

                entity.Property(e => e.UExpenseFormstatusId).HasColumnName("U_ExpenseFormstatusID");

                entity.Property(e => e.UUserId).HasColumnName("U_UserID");

                entity.HasOne(d => d.UExpenseCurrency)
                    .WithMany(p => p.ExpenseFormHistories)
                    .HasForeignKey(d => d.UExpenseCurrencyId)
                    .HasConstraintName("FK__ExpenseFo__U_Exp__37A5467C");

                entity.HasOne(d => d.UExpenseForm)
                    .WithMany(p => p.ExpenseFormHistories)
                    .HasForeignKey(d => d.UExpenseFormId)
                    .HasConstraintName("FK__ExpenseFo__U_Exp__34C8D9D1");

                entity.HasOne(d => d.UExpenseFormstatus)
                    .WithMany(p => p.ExpenseFormHistories)
                    .HasForeignKey(d => d.UExpenseFormstatusId)
                    .HasConstraintName("FK__ExpenseFo__U_Exp__35BCFE0A");

                entity.HasOne(d => d.UUser)
                    .WithMany(p => p.ExpenseFormHistories)
                    .HasForeignKey(d => d.UUserId)
                    .HasConstraintName("FK__ExpenseFo__U_Use__36B12243");
            });

            modelBuilder.Entity<ExpenseHistory>(entity =>
            {
                entity.HasKey(e => e.ExphId)
                    .HasName("PK__ExpenseH__FDA4C609C5E983AD");

                entity.ToTable("ExpenseHistory");

                entity.Property(e => e.ExphId).HasColumnName("Exph_ID");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.UExpenseFormHistoryId).HasColumnName("U_ExpenseFormHistoryID");

                entity.Property(e => e.UExpenseFormId).HasColumnName("U_ExpenseFormID");

                entity.Property(e => e.UExpenseFormstatusId).HasColumnName("U_ExpenseFormstatusID");

                entity.Property(e => e.UExpenseId).HasColumnName("U_ExpenseID");

                entity.Property(e => e.UUserId).HasColumnName("U_UserID");

                entity.HasOne(d => d.UExpenseFormHistory)
                    .WithMany(p => p.ExpenseHistories)
                    .HasForeignKey(d => d.UExpenseFormHistoryId)
                    .HasConstraintName("FK__ExpenseHi__U_Exp__3D5E1FD2");

                entity.HasOne(d => d.UExpenseForm)
                    .WithMany(p => p.ExpenseHistories)
                    .HasForeignKey(d => d.UExpenseFormId)
                    .HasConstraintName("FK__ExpenseHi__U_Exp__3A81B327");

                entity.HasOne(d => d.UExpenseFormstatus)
                    .WithMany(p => p.ExpenseHistories)
                    .HasForeignKey(d => d.UExpenseFormstatusId)
                    .HasConstraintName("FK__ExpenseHi__U_Exp__3B75D760");

                entity.HasOne(d => d.UExpense)
                    .WithMany(p => p.ExpenseHistories)
                    .HasForeignKey(d => d.UExpenseId)
                    .HasConstraintName("FK__ExpenseHi__U_Exp__3C69FB99");

                entity.HasOne(d => d.UUser)
                    .WithMany(p => p.ExpenseHistories)
                    .HasForeignKey(d => d.UUserId)
                    .HasConstraintName("FK__ExpenseHi__U_Use__3E52440B");
            });

            modelBuilder.Entity<ExpenseStatus>(entity =>
            {
                entity.HasKey(e => e.ExId)
                    .HasName("PK__ExpenseS__410CF917B6F0C3E5");

                entity.ToTable("ExpenseStatus");

                entity.Property(e => e.ExId).HasColumnName("Ex_ID");

                entity.Property(e => e.UrDegree)
                    .HasMaxLength(50)
                    .HasColumnName("Ur_Degree");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasKey(e => e.LId)
                    .HasName("PK__Log__420BA09E4D248977");

                entity.ToTable("Log");

                entity.Property(e => e.LId).HasColumnName("L_ID");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.UUserId).HasColumnName("U_UserID");

                entity.HasOne(d => d.UUser)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.UUserId)
                    .HasConstraintName("FK__Log__U_UserID__412EB0B6");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasKey(e => e.RId)
                    .HasName("PK__Resource__DE152E89004DDF46");

                entity.ToTable("Resource");

                entity.Property(e => e.RId).HasColumnName("R_ID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UId)
                    .HasName("PK__Users__5A2040DBC95C6870");

                entity.Property(e => e.UId).HasColumnName("U_ID");

                entity.Property(e => e.UDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("U_DateTime");

                entity.Property(e => e.UEmail)
                    .HasMaxLength(12)
                    .HasColumnName("U_Email");

                entity.Property(e => e.UName)
                    .HasMaxLength(50)
                    .HasColumnName("U_Name");

                entity.Property(e => e.UPasword).HasColumnName("U_Pasword");

                entity.Property(e => e.UPhoneNumber).HasColumnName("U_PhoneNumber");

                entity.Property(e => e.USurname)
                    .HasMaxLength(50)
                    .HasColumnName("U_Surname");

                entity.Property(e => e.UUserRoleId).HasColumnName("U_UserRoleID");

                entity.HasOne(d => d.UUserRole)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UUserRoleId)
                    .HasConstraintName("FK__Users__U_UserRol__2A4B4B5E");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.UrId)
                    .HasName("PK__UserRole__B8D3DC0650D96E5D");

                entity.ToTable("UserRole");

                entity.Property(e => e.UrId).HasColumnName("Ur_ID");

                entity.Property(e => e.UrDegree)
                    .HasMaxLength(50)
                    .HasColumnName("Ur_Degree");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
