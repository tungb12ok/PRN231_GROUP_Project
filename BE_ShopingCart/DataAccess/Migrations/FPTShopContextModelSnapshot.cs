﻿// <auto-generated />
using System;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(FPTshopContext))]
    partial class FPTshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataAccess.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Status" }, "IX_Category_Status");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Avatar")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Rate")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("date");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ProductId" }, "IX_Feedback_ProductId");

                    b.HasIndex(new[] { "UserId" }, "IX_Feedback_UserId");

                    b.ToTable("Feedback", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("date");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Status" }, "IX_Order_Status");

                    b.HasIndex(new[] { "UserId" }, "IX_Order_UserId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "OrderId" }, "IX_OrderDetail_OrderId");

                    b.HasIndex(new[] { "ProductId" }, "IX_OrderDetail_ProductId");

                    b.ToTable("OrderDetail", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PrimaryImage")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ProductName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Status" }, "IX_Product_Status");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PathImage")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ProductId" }, "IX_ProductImage_ProductId");

                    b.ToTable("ProductImage", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.ProductVariant", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Color")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("color");

                    b.Property<bool?>("Lock")
                        .HasColumnType("bit")
                        .HasColumnName("lock");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("productId");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("size");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductVariants");
                });

            modelBuilder.Entity("DataAccess.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("RoleName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Setting", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("decimal(18,0)");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "OrderId" }, "IX_Transaction_OrderId");

                    b.HasIndex(new[] { "Status" }, "IX_Transaction_Status");

                    b.HasIndex(new[] { "UserId" }, "IX_Transaction_UserId");

                    b.ToTable("Transaction", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Avatar")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Fullname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.HasKey("UserId");

                    b.HasIndex(new[] { "RoleId" }, "IX_User_RoleId");

                    b.HasIndex(new[] { "Status" }, "IX_User_Status");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Voucher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<DateTime?>("Expired")
                        .HasColumnType("date");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Status" }, "IX_Voucher_Status");

                    b.ToTable("Voucher", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Category", b =>
                {
                    b.HasOne("DataAccess.Models.Setting", "StatusNavigation")
                        .WithMany("Categories")
                        .HasForeignKey("Status")
                        .HasConstraintName("FK_Category_Setting");

                    b.Navigation("StatusNavigation");
                });

            modelBuilder.Entity("DataAccess.Models.Customer", b =>
                {
                    b.HasOne("DataAccess.Models.User", "CustomerNavigation")
                        .WithOne("Customer")
                        .HasForeignKey("DataAccess.Models.Customer", "CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK_Customer_User");

                    b.Navigation("CustomerNavigation");
                });

            modelBuilder.Entity("DataAccess.Models.Feedback", b =>
                {
                    b.HasOne("DataAccess.Models.Product", "Product")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_Feedback_Product");

                    b.HasOne("DataAccess.Models.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Feedback_User");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Models.Order", b =>
                {
                    b.HasOne("DataAccess.Models.Setting", "StatusNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("Status")
                        .HasConstraintName("FK_Order_Setting");

                    b.HasOne("DataAccess.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_User");

                    b.Navigation("StatusNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Models.OrderDetail", b =>
                {
                    b.HasOne("DataAccess.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_OrderDetail_Order");

                    b.HasOne("DataAccess.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_OrderDetail_Product");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DataAccess.Models.Product", b =>
                {
                    b.HasOne("DataAccess.Models.Setting", "StatusNavigation")
                        .WithMany("Products")
                        .HasForeignKey("Status")
                        .HasConstraintName("FK_Product_Setting");

                    b.Navigation("StatusNavigation");
                });

            modelBuilder.Entity("DataAccess.Models.ProductImage", b =>
                {
                    b.HasOne("DataAccess.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_ProductImage_Product");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DataAccess.Models.ProductVariant", b =>
                {
                    b.HasOne("DataAccess.Models.Product", "Product")
                        .WithMany("ProductVariants")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_ProductVariants_Product");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DataAccess.Models.Transaction", b =>
                {
                    b.HasOne("DataAccess.Models.Order", "Order")
                        .WithMany("Transactions")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_Transaction_Order");

                    b.HasOne("DataAccess.Models.Setting", "StatusNavigation")
                        .WithMany("Transactions")
                        .HasForeignKey("Status")
                        .IsRequired()
                        .HasConstraintName("FK_Transaction_Setting");

                    b.HasOne("DataAccess.Models.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Transaction_User");

                    b.Navigation("Order");

                    b.Navigation("StatusNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Models.User", b =>
                {
                    b.HasOne("DataAccess.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_User_Role");

                    b.HasOne("DataAccess.Models.Setting", "StatusNavigation")
                        .WithMany("Users")
                        .HasForeignKey("Status")
                        .HasConstraintName("FK_User_Setting");

                    b.Navigation("Role");

                    b.Navigation("StatusNavigation");
                });

            modelBuilder.Entity("DataAccess.Models.Voucher", b =>
                {
                    b.HasOne("DataAccess.Models.Setting", "StatusNavigation")
                        .WithMany("Vouchers")
                        .HasForeignKey("Status")
                        .IsRequired()
                        .HasConstraintName("FK_Voucher_Setting");

                    b.Navigation("StatusNavigation");
                });

            modelBuilder.Entity("DataAccess.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("DataAccess.Models.Product", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("OrderDetails");

                    b.Navigation("ProductImages");

                    b.Navigation("ProductVariants");
                });

            modelBuilder.Entity("DataAccess.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DataAccess.Models.Setting", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Orders");

                    b.Navigation("Products");

                    b.Navigation("Transactions");

                    b.Navigation("Users");

                    b.Navigation("Vouchers");
                });

            modelBuilder.Entity("DataAccess.Models.User", b =>
                {
                    b.Navigation("Customer");

                    b.Navigation("Feedbacks");

                    b.Navigation("Orders");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
