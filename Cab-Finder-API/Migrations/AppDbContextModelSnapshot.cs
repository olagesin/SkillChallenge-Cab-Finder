﻿// <auto-generated />
using System;
using Cab_Finder_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CabFinderAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Cab_Finder_Lib.Models.DatabaseModels.LocationDb", b =>
                {
                    b.Property<int>("location_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("location_Id"));

                    b.Property<double>("destination_coord_lat")
                        .HasColumnType("double precision");

                    b.Property<double>("destination_coord_long")
                        .HasColumnType("double precision");

                    b.Property<string>("location_description")
                        .HasColumnType("text");

                    b.Property<double>("start_coord_lat")
                        .HasColumnType("double precision");

                    b.Property<double>("start_coord_long")
                        .HasColumnType("double precision");

                    b.HasKey("location_Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Cab_Finder_Lib.Models.DatabaseModels.RideDb", b =>
                {
                    b.Property<int>("ride_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ride_id"));

                    b.Property<DateTime>("estimated_arrival_time")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("location_id")
                        .HasColumnType("integer");

                    b.Property<int>("rideservice_id")
                        .HasColumnType("integer");

                    b.HasKey("ride_id");

                    b.HasIndex("location_id");

                    b.HasIndex("rideservice_id");

                    b.ToTable("Rides");
                });

            modelBuilder.Entity("Cab_Finder_Lib.Models.DatabaseModels.RideServiceDb", b =>
                {
                    b.Property<int>("rideservice_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("rideservice_id"));

                    b.Property<decimal>("priceperkm")
                        .HasColumnType("numeric");

                    b.Property<string>("rideservice_name")
                        .HasColumnType("text");

                    b.HasKey("rideservice_id");

                    b.ToTable("RideServices");
                });

            modelBuilder.Entity("Cab_Finder_Lib.Models.DatabaseModels.RideDb", b =>
                {
                    b.HasOne("Cab_Finder_Lib.Models.DatabaseModels.LocationDb", "location")
                        .WithMany()
                        .HasForeignKey("location_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cab_Finder_Lib.Models.DatabaseModels.RideServiceDb", "rideservice")
                        .WithMany()
                        .HasForeignKey("rideservice_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("location");

                    b.Navigation("rideservice");
                });
#pragma warning restore 612, 618
        }
    }
}