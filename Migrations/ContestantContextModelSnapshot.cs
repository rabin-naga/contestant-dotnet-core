﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using contestant.Models;

namespace contestant.Migrations
{
    [DbContext(typeof(ContestantContext))]
    partial class ContestantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("contestant.Models.Contestant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<int?>("DistrictId");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .HasMaxLength(50);

                    b.Property<bool?>("IsActive");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhotoUrl");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("Contestant");
                });

            modelBuilder.Entity("contestant.Models.ContestantRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContestantId");

                    b.Property<DateTime>("RatedDate");

                    b.Property<int>("Rating");

                    b.HasKey("Id");

                    b.HasIndex("ContestantId");

                    b.ToTable("ContestantRating");
                });

            modelBuilder.Entity("contestant.Models.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("District");
                });

            modelBuilder.Entity("contestant.Models.Contestant", b =>
                {
                    b.HasOne("contestant.Models.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");
                });

            modelBuilder.Entity("contestant.Models.ContestantRating", b =>
                {
                    b.HasOne("contestant.Models.Contestant", "Contestant")
                        .WithMany()
                        .HasForeignKey("ContestantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
