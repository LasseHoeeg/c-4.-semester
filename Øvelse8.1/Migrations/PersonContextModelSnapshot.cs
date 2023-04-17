﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Øvelse8._1.DBFolder;

#nullable disable

namespace Øvelse8._1.Migrations
{
    [DbContext(typeof(PersonContext))]
    partial class PersonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Øvelse8._1.Klasse", b =>
                {
                    b.Property<int>("KlasseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KlasseId"));

                    b.Property<string>("Aargang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KlasseNavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KlasseId");

                    b.ToTable("Klasser");
                });

            modelBuilder.Entity("Øvelse8._1.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KlasseId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KlasseId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Øvelse8._1.Person", b =>
                {
                    b.HasOne("Øvelse8._1.Klasse", "Klasse")
                        .WithMany()
                        .HasForeignKey("KlasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klasse");
                });
#pragma warning restore 612, 618
        }
    }
}
