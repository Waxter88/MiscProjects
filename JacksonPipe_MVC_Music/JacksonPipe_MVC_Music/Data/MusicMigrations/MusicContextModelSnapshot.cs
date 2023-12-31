﻿// <auto-generated />
using System;
using JacksonPipe_MVC_Music.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JacksonPipe_MVC_Music.Data.MusicMigrations
{
    [DbContext(typeof(MusicContext))]
    partial class MusicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("JacksonPipe_MVC_Music.Models.Instrument", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Instruments");
                });

            modelBuilder.Entity("JacksonPipe_MVC_Music.Models.Musician", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int>("InstrumentID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.Property<string>("SIN")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("InstrumentID");

                    b.HasIndex("SIN")
                        .IsUnique();

                    b.ToTable("Musicians");
                });

            modelBuilder.Entity("JacksonPipe_MVC_Music.Models.Play", b =>
                {
                    b.Property<int>("InstrumentID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MusicianID")
                        .HasColumnType("INTEGER");

                    b.HasKey("InstrumentID", "MusicianID");

                    b.HasIndex("MusicianID");

                    b.ToTable("Plays");
                });

            modelBuilder.Entity("JacksonPipe_MVC_Music.Models.Musician", b =>
                {
                    b.HasOne("JacksonPipe_MVC_Music.Models.Instrument", "Instrument")
                        .WithMany()
                        .HasForeignKey("InstrumentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instrument");
                });

            modelBuilder.Entity("JacksonPipe_MVC_Music.Models.Play", b =>
                {
                    b.HasOne("JacksonPipe_MVC_Music.Models.Instrument", "Instrument")
                        .WithMany("Play")
                        .HasForeignKey("InstrumentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JacksonPipe_MVC_Music.Models.Musician", "Musician")
                        .WithMany("Play")
                        .HasForeignKey("MusicianID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Instrument");

                    b.Navigation("Musician");
                });

            modelBuilder.Entity("JacksonPipe_MVC_Music.Models.Instrument", b =>
                {
                    b.Navigation("Play");
                });

            modelBuilder.Entity("JacksonPipe_MVC_Music.Models.Musician", b =>
                {
                    b.Navigation("Play");
                });
#pragma warning restore 612, 618
        }
    }
}
