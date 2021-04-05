﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SECRM.Context;

namespace SECRM.Migrations
{
    [DbContext(typeof(CRMContext))]
    partial class CRMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("SECRM.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Machine")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("SECRM.Models.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Catalog")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("SECRM.Models.Embroidery", b =>
                {
                    b.Property<int>("EmbroideryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BackHeight")
                        .HasColumnType("INTEGER");

                    b.Property<double>("BackPrice")
                        .HasColumnType("REAL");

                    b.Property<int>("BackWidth")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FrontHight")
                        .HasColumnType("INTEGER");

                    b.Property<double>("FrontPrice")
                        .HasColumnType("REAL");

                    b.Property<int>("FrontWidth")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Observations")
                        .HasColumnType("TEXT");

                    b.Property<double>("ProgrammingPrice")
                        .HasColumnType("REAL");

                    b.Property<int>("StitchesQty")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmbroideryId");

                    b.ToTable("Embroideries");
                });

            modelBuilder.Entity("SECRM.Models.EmbroideryColor", b =>
                {
                    b.Property<int>("EmbroideryColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmbroideryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmbroideryColorId");

                    b.HasIndex("ColorId");

                    b.HasIndex("EmbroideryId");

                    b.ToTable("EmbroideryColors");
                });

            modelBuilder.Entity("SECRM.Models.EmbroideryColor", b =>
                {
                    b.HasOne("SECRM.Models.Color", "Color")
                        .WithMany("EmbroideryColors")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SECRM.Models.Embroidery", "Embroidery")
                        .WithMany("EmbroideryColors")
                        .HasForeignKey("EmbroideryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Embroidery");
                });

            modelBuilder.Entity("SECRM.Models.Color", b =>
                {
                    b.Navigation("EmbroideryColors");
                });

            modelBuilder.Entity("SECRM.Models.Embroidery", b =>
                {
                    b.Navigation("EmbroideryColors");
                });
#pragma warning restore 612, 618
        }
    }
}
