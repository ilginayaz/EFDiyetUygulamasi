﻿// <auto-generated />
using System;
using EFDiyet.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFDiyet.DAL.Migrations
{
    [DbContext(typeof(DietDbContext))]
    [Migration("20240319213052_DbOlusturma1")]
    partial class DbOlusturma1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Meyve",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Sebze",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Et Ürünleri",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Salata",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Unlu Mamuller",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Tatlı",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "İçecek",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false
                        });
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Meals", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            MealName = "Kahvaltı"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            MealName = "Öğle Yemeği"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            MealName = "Akşam Yemeği"
                        });
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.Nutrition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Calories")
                        .HasColumnType("real");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("NutritionName")
                        .IsRequired()
                        .HasMaxLength(110)
                        .HasColumnType("nvarchar(110)");

                    b.Property<int>("NutritionValueId")
                        .HasColumnType("int");

                    b.Property<int>("Portion")
                        .HasColumnType("int");

                    b.Property<float>("PortionSize")
                        .HasColumnType("real");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("NutritionValueId");

                    b.ToTable("Nutritions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calories = 52f,
                            CategoryId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            NutritionName = "Elma",
                            NutritionValueId = 1,
                            Portion = 13,
                            PortionSize = 1f
                        },
                        new
                        {
                            Id = 2,
                            Calories = 18f,
                            CategoryId = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            NutritionName = "Domates",
                            NutritionValueId = 2,
                            Portion = 13,
                            PortionSize = 1f
                        });
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.NutritionValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("NutritionValueName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("NutritionValues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            NutritionValueName = "Karbonhidrat"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            NutritionValueName = "Protein"
                        });
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Picture")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SecurityQuestion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "5",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ish@gmail.com.com",
                            IsActive = false,
                            Name = "ılgısü",
                            Password = "1234",
                            SecurityQuestion = "Favori sayın kaçtır?",
                            Surname = "Hiv",
                            UserType = 2
                        },
                        new
                        {
                            Id = 2,
                            Answer = "1",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            IsActive = false,
                            Name = "Hivda Ilgın",
                            Password = "admin1234",
                            SecurityQuestion = "Favori sayın kaçtır?",
                            Surname = "Sümeyye",
                            UserType = 1
                        });
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.UserDetail", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("UsersDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2003, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = 1,
                            Height = 175.5f,
                            IsActive = false,
                            Weight = 50f
                        });
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.UserNutrition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("NutritionId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MealId");

                    b.HasIndex("NutritionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserNutritions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            MealId = 1,
                            NutritionId = 1,
                            Quantity = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            MealId = 2,
                            NutritionId = 2,
                            Quantity = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.Nutrition", b =>
                {
                    b.HasOne("EFDiyet.DAL.Context.Entities.Concrete.Category", "Category")
                        .WithMany("Nutrition")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFDiyet.DAL.Context.Entities.Concrete.NutritionValue", "NutritionValue")
                        .WithMany("Nutrition")
                        .HasForeignKey("NutritionValueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("NutritionValue");
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.UserDetail", b =>
                {
                    b.HasOne("EFDiyet.DAL.Context.Entities.Concrete.User", "User")
                        .WithOne("UserDetail")
                        .HasForeignKey("EFDiyet.DAL.Context.Entities.Concrete.UserDetail", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.UserNutrition", b =>
                {
                    b.HasOne("EFDiyet.DAL.Context.Entities.Concrete.Meal", "Meal")
                        .WithMany("UserNutrition")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFDiyet.DAL.Context.Entities.Concrete.Nutrition", "Nutrition")
                        .WithMany("UserNutrition")
                        .HasForeignKey("NutritionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFDiyet.DAL.Context.Entities.Concrete.User", "User")
                        .WithMany("UserNutrition")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meal");

                    b.Navigation("Nutrition");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Nutrition");
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.Meal", b =>
                {
                    b.Navigation("UserNutrition");
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.Nutrition", b =>
                {
                    b.Navigation("UserNutrition");
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.NutritionValue", b =>
                {
                    b.Navigation("Nutrition");
                });

            modelBuilder.Entity("EFDiyet.DAL.Context.Entities.Concrete.User", b =>
                {
                    b.Navigation("UserDetail")
                        .IsRequired();

                    b.Navigation("UserNutrition");
                });
#pragma warning restore 612, 618
        }
    }
}
