﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StudentPortal_DataAccess.Context.IdentityContext;

#nullable disable

namespace StudentPortal_DataAccess.IdentityContext.Migrations
{
    [DbContext(typeof(AppIdentityDbContext))]
    partial class AppIdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "6bebcad2-b4b3-46ed-b437-dbb5d4373229",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "4554501c-499a-47ef-b2cf-60dfffa42aa9",
                            Name = "student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "0f38a670-2f7b-4e35-99d4-357018ff35fe",
                            Name = "teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = "32f065e3-1790-4b27-95cf-948252f5d0d6",
                            Name = "hrPersonal",
                            NormalizedName = "HRPERSONAL"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "b6e412f3-9b23-4a20-a1af-d5babfd75db5",
                            RoleId = "6bebcad2-b4b3-46ed-b437-dbb5d4373229"
                        },
                        new
                        {
                            UserId = "81debc83-817b-4c81-8d04-b1a822be78c9",
                            RoleId = "4554501c-499a-47ef-b2cf-60dfffa42aa9"
                        },
                        new
                        {
                            UserId = "7c84991e-f980-4c42-8c08-f0c1fad65547",
                            RoleId = "4554501c-499a-47ef-b2cf-60dfffa42aa9"
                        },
                        new
                        {
                            UserId = "2de7310f-a715-4887-9919-7ccd29cf474a",
                            RoleId = "0f38a670-2f7b-4e35-99d4-357018ff35fe"
                        },
                        new
                        {
                            UserId = "b07931af-b4ed-4e01-9a06-9560d31ab594",
                            RoleId = "32f065e3-1790-4b27-95cf-948252f5d0d6"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("StudentPortal_Core.Entities.UserEntities.Concrete.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b6e412f3-9b23-4a20-a1af-d5babfd75db5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "58351ba3-8700-4eeb-9735-580f0e4ae814",
                            CreatedDate = new DateTime(2024, 2, 17, 20, 57, 13, 479, DateTimeKind.Local).AddTicks(6364),
                            Email = "admin@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@TEST.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEL+2oRuv/SohiaeeM2SJn1zEojJwcgtC6vKPMKutLycnfEsSqLwARFLftQ2eZ0xvzg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "269d1441-fcde-43f5-b20f-ff1256a421c6",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "81debc83-817b-4c81-8d04-b1a822be78c9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "54048abf-ed6a-4cd5-88d8-ecfe836dc96c",
                            CreatedDate = new DateTime(2024, 2, 17, 20, 57, 13, 548, DateTimeKind.Local).AddTicks(3438),
                            Email = "student@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT@TEST.COM",
                            NormalizedUserName = "STUDENT",
                            PasswordHash = "AQAAAAIAAYagAAAAEDBlPVF/LKwb2t1vhFjFSlHHinBD3uR4dpZkcNpZWJbg/olqjXxYIdAOa15UeinZRw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8ed69bfe-ccd2-44d6-a9f5-2e558f2e77dc",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "student"
                        },
                        new
                        {
                            Id = "7c84991e-f980-4c42-8c08-f0c1fad65547",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4bb9adc3-8156-44e7-b79f-c1d8e93e5c50",
                            CreatedDate = new DateTime(2024, 2, 17, 20, 57, 13, 616, DateTimeKind.Local).AddTicks(1291),
                            Email = "student2@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT2@TEST.COM",
                            NormalizedUserName = "STUDENT2",
                            PasswordHash = "AQAAAAIAAYagAAAAEOfkx1o065nJgsiYMyE8hngLbNRYdC//3ss52fhVUBJRAHbVlplFoFTIXDMOXyTXQQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b12056b6-ce37-4dd5-a12a-4b3e502bda8f",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "student2"
                        },
                        new
                        {
                            Id = "2de7310f-a715-4887-9919-7ccd29cf474a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3189c8aa-fd0b-44a9-beb4-44cf75098bff",
                            CreatedDate = new DateTime(2024, 2, 17, 20, 57, 13, 682, DateTimeKind.Local).AddTicks(6614),
                            Email = "teacher@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEACHER@TEST.COM",
                            NormalizedUserName = "TEACHER",
                            PasswordHash = "AQAAAAIAAYagAAAAEKbmHIdvbWxMF4N8VVXMGrHANDXTxGtDeT1RZuEaaU1AHelElJta/MM6Szh3B/+hkA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "96226f8a-b3ed-4098-b341-c993e6254d08",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "teacher"
                        },
                        new
                        {
                            Id = "b07931af-b4ed-4e01-9a06-9560d31ab594",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b8aee377-0d5e-4f0e-8865-e8200173e217",
                            CreatedDate = new DateTime(2024, 2, 17, 20, 57, 13, 751, DateTimeKind.Local).AddTicks(8472),
                            Email = "hrPersonel@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "HRPERSONEL@TEST.COM",
                            NormalizedUserName = "HRPERSONEL",
                            PasswordHash = "AQAAAAIAAYagAAAAEF1yXlDsdWG1WSZw2JTekvWMjCkBMrENNqTnB2V745UNbPuyOliwL6qZcsvjHiiWpQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ef2d6179-be15-4609-a1bc-5d31eaf5cd94",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "hrPersonel"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("StudentPortal_Core.Entities.UserEntities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StudentPortal_Core.Entities.UserEntities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentPortal_Core.Entities.UserEntities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StudentPortal_Core.Entities.UserEntities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}