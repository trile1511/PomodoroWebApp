﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PomodoroApp.Data;

namespace PomodoroApp.Migrations.Sqlite
{
    [DbContext(typeof(PomodoroContext))]
    [Migration("20220820082523_UpdateNumCompletedLongBreaksDataTypeInTaskEntity")]
    partial class UpdateNumCompletedLongBreaksDataTypeInTaskEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("PomodoroApp.Data.Entities.PomodoroConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AutoStartBreak")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AutoStartPom")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LongBreakInterval")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(4);

                    b.Property<int>("LongBreakLength")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(15);

                    b.Property<int>("PomodoroLength")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(25);

                    b.Property<int>("ShortBreakLength")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(5);

                    b.HasKey("Id");

                    b.ToTable("PomodoroConfigurations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AutoStartBreak = false,
                            AutoStartPom = false,
                            LongBreakInterval = 4,
                            LongBreakLength = 15,
                            PomodoroLength = 25,
                            ShortBreakLength = 5
                        });
                });

            modelBuilder.Entity("PomodoroApp.Data.Entities.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateTimeCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumCompletedLongBreaks")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumCompletedPoms")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumCompletedShortBreaks")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumEstimatedPoms")
                        .HasColumnType("INTEGER");

                    b.HasKey("TaskId");

                    b.ToTable("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
