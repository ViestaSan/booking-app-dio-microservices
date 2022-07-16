﻿// <auto-generated />
using System;
using BookingAppDio.Booking.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BookingAppDio.Booking.Infra.Data.Migrations
{
    [DbContext(typeof(BookingDbContext))]
    partial class BookingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BookingAppDio.Booking.Domain.Models.Booking", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("LastModifiedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Booking", (string)null);
                });

            modelBuilder.Entity("BookingAppDio.Booking.Domain.Models.Booking", b =>
                {
                    b.OwnsOne("BookingAppDio.Booking.Domain.Models.ValueObjects.PassengerInfo", "PassengerInfo", b1 =>
                        {
                            b1.Property<Guid>("BookingId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("BookingId");

                            b1.ToTable("Booking");

                            b1.WithOwner()
                                .HasForeignKey("BookingId");
                        });

                    b.OwnsOne("BookingAppDio.Booking.Domain.Models.ValueObjects.Trip", "Trip", b1 =>
                        {
                            b1.Property<Guid>("BookingId")
                                .HasColumnType("uuid");

                            b1.Property<long>("AircraftId")
                                .HasColumnType("bigint");

                            b1.Property<long>("ArriveAirportId")
                                .HasColumnType("bigint");

                            b1.Property<long>("DepartureAirportId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Description")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<DateTime>("FlightDate")
                                .HasColumnType("timestamp without time zone");

                            b1.Property<string>("FlightNumber")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<decimal>("Price")
                                .HasColumnType("numeric");

                            b1.Property<string>("SeatNumber")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("BookingId");

                            b1.ToTable("Booking");

                            b1.WithOwner()
                                .HasForeignKey("BookingId");
                        });

                    b.Navigation("PassengerInfo")
                        .IsRequired();

                    b.Navigation("Trip")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
