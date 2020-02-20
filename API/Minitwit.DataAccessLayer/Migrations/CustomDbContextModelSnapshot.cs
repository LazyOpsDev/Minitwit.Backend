﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Minitwit.DataAccessLayer;

namespace Minitwit.DataAccessLayer.Migrations
{
    [DbContext(typeof(CustomDbContext))]
    partial class CustomDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Minitwit.Models.Follower", b =>
                {
                    b.Property<Guid>("FollowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("FollowingUserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("SelfUserId")
                        .HasColumnType("char(36)");

                    b.HasKey("FollowerId");

                    b.HasIndex("FollowingUserId");

                    b.HasIndex("SelfUserId");

                    b.ToTable("Followers");
                });

            modelBuilder.Entity("Minitwit.Models.LatestModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("latest")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Latest");
                });

            modelBuilder.Entity("Minitwit.Models.Message", b =>
                {
                    b.Property<Guid>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Flagged")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("PublishedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("TestKey")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("MessageId");

                    b.HasIndex("TestKey");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Minitwit.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Minitwit.Models.Follower", b =>
                {
                    b.HasOne("Minitwit.Models.User", "Following")
                        .WithMany()
                        .HasForeignKey("FollowingUserId");

                    b.HasOne("Minitwit.Models.User", "Self")
                        .WithMany()
                        .HasForeignKey("SelfUserId");
                });

            modelBuilder.Entity("Minitwit.Models.Message", b =>
                {
                    b.HasOne("Minitwit.Models.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("TestKey");
                });
#pragma warning restore 612, 618
        }
    }
}
