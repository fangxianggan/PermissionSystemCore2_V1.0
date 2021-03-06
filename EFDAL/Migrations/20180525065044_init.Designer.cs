﻿// <auto-generated />
using EFDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EFDAL.Migrations
{
    [DbContext(typeof(PerDbContext))]
    [Migration("20180525065044_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFEntity.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateTime");

                    b.Property<int>("CreateUserId");

                    b.Property<string>("DeptCode")
                        .HasMaxLength(20);

                    b.Property<string>("DeptName")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("EFEntity.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateTime");

                    b.Property<int>("CreateUserId");

                    b.Property<int>("DeptId");

                    b.Property<string>("LoginName")
                        .HasMaxLength(20);

                    b.Property<string>("Password");

                    b.Property<string>("UserName")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("EFEntity.Models.User", b =>
                {
                    b.HasOne("EFEntity.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
