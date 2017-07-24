using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using raspberry_api.Models;

namespace raspberryapi.Migrations
{
    [DbContext(typeof(TemperaturesContext))]
    partial class TemperaturesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("raspberry_api.Models.Reading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Humidity");

                    b.Property<float>("Temperature");

                    b.Property<DateTime>("TimeStamp")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2017, 7, 24, 10, 53, 16, 922, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.ToTable("Readings");
                });
        }
    }
}
