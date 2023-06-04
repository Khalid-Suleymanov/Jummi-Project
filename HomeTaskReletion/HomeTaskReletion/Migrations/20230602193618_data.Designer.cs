﻿// <auto-generated />
using HomeTaskReletion.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HomeTaskReletion.Migrations
{
    [DbContext(typeof(ReletionDbContext))]
    [Migration("20230602193618_data")]
    partial class data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HomeTaskReletion.Entities.Chef", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionId");

                    b.ToTable("Chefs");
                });

            modelBuilder.Entity("HomeTaskReletion.Entities.ChefSocialMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ChefId")
                        .HasColumnType("int");

                    b.Property<string>("FbUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwitterUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChefId")
                        .IsUnique();

                    b.ToTable("ChefSocialMedias");
                });

            modelBuilder.Entity("HomeTaskReletion.Entities.Profession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("HomeTaskReletion.Entities.Testimonial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionId");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("HomeTaskReletion.Entities.Chef", b =>
                {
                    b.HasOne("HomeTaskReletion.Entities.Profession", "Profession")
                        .WithMany("Chefs")
                        .HasForeignKey("ProfessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profession");
                });

            modelBuilder.Entity("HomeTaskReletion.Entities.ChefSocialMedia", b =>
                {
                    b.HasOne("HomeTaskReletion.Entities.Chef", "Chef")
                        .WithOne("ChefSocialMedia")
                        .HasForeignKey("HomeTaskReletion.Entities.ChefSocialMedia", "ChefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chef");
                });

            modelBuilder.Entity("HomeTaskReletion.Entities.Testimonial", b =>
                {
                    b.HasOne("HomeTaskReletion.Entities.Profession", "Profession")
                        .WithMany("Testimonials")
                        .HasForeignKey("ProfessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profession");
                });

            modelBuilder.Entity("HomeTaskReletion.Entities.Chef", b =>
                {
                    b.Navigation("ChefSocialMedia");
                });

            modelBuilder.Entity("HomeTaskReletion.Entities.Profession", b =>
                {
                    b.Navigation("Chefs");

                    b.Navigation("Testimonials");
                });
#pragma warning restore 612, 618
        }
    }
}