﻿// <auto-generated />
using System;
using MMMarketTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MMMarketTracker.Migrations
{
    [DbContext(typeof(MMMarketTrackerContext))]
    partial class MMMarketTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("MMMarketTrader.Models.MarketSaleRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Item");

                    b.Property<long>("Price");

                    b.HasKey("Id");

                    b.ToTable("MarketSaleRecord");
                });
#pragma warning restore 612, 618
        }
    }
}