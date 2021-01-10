using DevExpress.Xpo;
using Microsoft.EntityFrameworkCore;
using ModelDatabase.EF;
using System;

namespace ModelDatabase
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserAccount> UserAccount { set; get; }
        public DbSet<Category> Category { set; get; }
        public DbSet<Product> Product { set; get; }
        public DbSet<Customer> Customer { set; get; }
        public DbSet<Bill> Bill { set; get; }
        public DbSet<BillItem> BillItem { set; get; }


        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {

            //UserAccount
            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.HasKey(e => e.UserId);       //khóa chính

                entity.Property(e => e.UserName)
                .HasColumnName("UserName")          //Tên cột
                .HasColumnType("nvarchar(250)")     //Độ dài
                .IsRequired(true);                  //Không null
                entity.HasIndex(e => e.UserName)    
                .IsUnique(true);                    //Không được trùng

                entity.Property(e => e.Password)
                .HasColumnName("Password")
                .HasColumnType("nvarchar(MAX)")
                .IsRequired(true);

            });

            //Categorry
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(250)")
                .IsRequired(true);
                entity.HasIndex(e => e.Name)
                .IsUnique(true);
                
                entity.Property(e => e.Image)
                .HasColumnName("Image")
                .HasColumnType("nvarchar(MAX)")
                .IsRequired(true);

                entity.Property(e => e.dateTime).IsRequired(true);
               

            });

            //Product
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.Property(e => e.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(250)")
                .IsRequired(true);
                entity.HasIndex(e => e.Name)
                .IsUnique(true);

                entity.HasOne(e => e.category)
                .WithMany(Product => Product.products)
                .HasForeignKey("CategoryID")
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Product_Category");

                entity.Property(e => e.Quantiy)
                .HasColumnName("Quanity")
                .HasColumnType("int")
                .HasDefaultValue(0)
                .IsRequired(true);

                entity.Property(e => e.Price)
                .HasColumnName("Price")
                .HasDefaultValue(0.0)
                .IsRequired(true);

                entity.Property(e => e.Image)
                .HasColumnName("Image")
                .HasColumnType("nvarchar(MAX)")
                .IsRequired(true);
            });

            //Customer
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.Property(e => e.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(250)")
                .IsRequired(true);

                entity.Property(e => e.Phone)
                .HasColumnName("Phone")
                .HasColumnType("nvarchar(20)")
                .IsRequired(true);

                entity.Property(e => e.Gender)
                .HasColumnName("Gender")
                .HasColumnType("nvarchar(10)");

                entity.Property(e => e.dateTime).IsRequired(true);


            });
            //Bill
            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(key => key.ID);

               entity.HasOne(e => e.Customer)
              .WithMany(customer => customer.Bills)
              .HasForeignKey("CustomerID")
              .OnDelete(DeleteBehavior.SetNull)
              .HasConstraintName("FK_Bill_Customer");
            });
            //BillItem
            modelBuilder.Entity<BillItem>(entity =>
            {
                entity.HasKey(key => key.ID);

                entity.HasOne(e => e.Product)
                .WithMany(pro => pro.billItems)
                .HasForeignKey("ProductID")
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_billItem_Product");

                entity.HasOne(e => e.Bill)
                .WithMany(bill => bill.billItems)
                .HasForeignKey("BillID")
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_billItem_Bill");

                entity.Property(e => e.ProductName)
                .HasColumnName("ProductName")
                .HasColumnType("nvarchar(250)")
                .IsRequired(true);

                entity.Property(e => e.Price)
                .HasColumnName("Price")
                .HasDefaultValue(0.0)
                .IsRequired(true);
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-LKV2N3U;Data Source=DESKTOP-LKV2N3U;Initial Catalog=QLNS;Integrated Security=True;MultipleActiveResultSets=true");
        }
    }
}