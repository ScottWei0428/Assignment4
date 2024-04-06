using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Assignment4.Models.Entities;

public partial class MMABooksContext : DbContext
{
    public MMABooksContext()
    {
    }

    public MMABooksContext(DbContextOptions<MMABooksContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<TransactionHistory> TransactionHistories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Application_Dev_using_C#.Net-ITE-5230-IRA\\Assignment4\\Assignment4\\ASSN4DB.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__Account__349DA5A627F95F7D");

            entity.ToTable("Account");

            entity.Property(e => e.AccountType).HasMaxLength(100);
            entity.Property(e => e.CurrentBalance).HasDefaultValue(0.0);
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TransactionHistory>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Transact__55433A6B7EE3B2CD");

            entity.ToTable("TransactionHistory");

            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.TransactionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07097F1A41");

            entity.ToTable("User");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Firstname).HasMaxLength(50);
            entity.Property(e => e.Lastname).HasMaxLength(50);
        });

        var users = new List<User>();
        for (int i = 1; i <= 10; i++)
        {
            users.Add(new User
            {
                Id = i,
                Firstname = $"Firstname{i}",
                Lastname = $"Lastname{i}",
                Email = $"user{i}@example.com",
                Password = $"hashed-password-{i}",
                DateCreated = DateTime.Now
            });
        }
        modelBuilder.Entity<User>().HasData(users);


        var accounts = new List<Account>();
        var transactionRecord = new List<TransactionHistory>();
        for (int i = 1; i <= 10; i++)
        {
            accounts.Add(new Account
            {
                AccountId = i, 
                UserId = i, 
                AccountType = i % 2 == 0 ? "Savings" : "Checking",
                CurrentBalance = (float)1000m * i, 
                DateCreated = DateTime.Now
            });

           
            for (int j = 1; j <= 10; j++)
            {
                transactionRecord.Add(new TransactionHistory
                {
                    TransactionId = i * 10 + j, 
                    AccountId = i,
                    TransactionDate = DateTime.Now.AddDays(-j),
                    Amount = 100m * j, 
                    Description = $"Transaction {j} for Account {i}"
                });
            }
        }
        modelBuilder.Entity<Account>().HasData(accounts);
        modelBuilder.Entity<TransactionHistory>().HasData(transactionRecord);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
