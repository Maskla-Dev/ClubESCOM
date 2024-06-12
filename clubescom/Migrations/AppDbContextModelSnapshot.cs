﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using clubescom.manager;

#nullable disable

namespace clubescom.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.5.24306.3");

            modelBuilder.Entity("clubescom.manager.models.Calendar", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClubID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("RepeatEveryWeek")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("ClubID");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("clubescom.manager.models.Club", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BannerID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("LogoID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PresidentID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("BannerID");

                    b.HasIndex("LogoID");

                    b.HasIndex("PresidentID");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("clubescom.manager.models.Image", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("clubescom.manager.models.Post", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AuthorID")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClubID")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ImageID")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PostTypeID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("enabled")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("ClubID");

                    b.HasIndex("ImageID");

                    b.HasIndex("PostTypeID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("clubescom.manager.models.PostType", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("PostTypes");
                });

            modelBuilder.Entity("clubescom.manager.models.Rol", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("clubescom.manager.models.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProfileImageID")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RolID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("ProfileImageID");

                    b.HasIndex("RolID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("clubescom.manager.models.Calendar", b =>
                {
                    b.HasOne("clubescom.manager.models.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");
                });

            modelBuilder.Entity("clubescom.manager.models.Club", b =>
                {
                    b.HasOne("clubescom.manager.models.Image", "Banner")
                        .WithMany()
                        .HasForeignKey("BannerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("clubescom.manager.models.Image", "Logo")
                        .WithMany()
                        .HasForeignKey("LogoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("clubescom.manager.models.User", "President")
                        .WithMany()
                        .HasForeignKey("PresidentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banner");

                    b.Navigation("Logo");

                    b.Navigation("President");
                });

            modelBuilder.Entity("clubescom.manager.models.Post", b =>
                {
                    b.HasOne("clubescom.manager.models.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("clubescom.manager.models.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("clubescom.manager.models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("clubescom.manager.models.PostType", "PostType")
                        .WithMany()
                        .HasForeignKey("PostTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Club");

                    b.Navigation("Image");

                    b.Navigation("PostType");
                });

            modelBuilder.Entity("clubescom.manager.models.User", b =>
                {
                    b.HasOne("clubescom.manager.models.Image", "ProfileImage")
                        .WithMany()
                        .HasForeignKey("ProfileImageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("clubescom.manager.models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProfileImage");

                    b.Navigation("Rol");
                });
#pragma warning restore 612, 618
        }
    }
}
