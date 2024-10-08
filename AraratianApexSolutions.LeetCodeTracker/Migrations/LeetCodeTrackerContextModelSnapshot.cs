﻿// <auto-generated />
using System;
using AraratianApexSolutions.LeetCodeTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AraratianApexSolutions.LeetCodeTracker.Migrations
{
    [DbContext(typeof(LeetCodeTrackerDbContext))]
    partial class LeetCodeTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AraratianApexSolutions.LeetCodeTracker.Models.Question", b =>
                {
                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Number");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("AraratianApexSolutions.LeetCodeTracker.Models.QuestionDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionNumber");

                    b.ToTable("QuestionDescription");
                });

            modelBuilder.Entity("AraratianApexSolutions.LeetCodeTracker.Models.QuestionDescription", b =>
                {
                    b.HasOne("AraratianApexSolutions.LeetCodeTracker.Models.Question", "Question")
                        .WithMany("Description")
                        .HasForeignKey("QuestionNumber");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("AraratianApexSolutions.LeetCodeTracker.Models.Question", b =>
                {
                    b.Navigation("Description");
                });
#pragma warning restore 612, 618
        }
    }
}
