﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _tiburon.Models;

namespace _tiburon.Migrations
{
    [DbContext(typeof(RespondentContext))]
    [Migration("20180609162505_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_tiburon.Models.Entities.RespondetnPhoneMark", b =>
                {
                    b.Property<int>("PhoneMarkId");

                    b.Property<int>("RespondentId");

                    b.HasKey("PhoneMarkId", "RespondentId");

                    b.HasIndex("RespondentId");

                    b.ToTable("RespondetnPhoneMark");
                });

            modelBuilder.Entity("_tiburon.Models.PhoneMark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PhoneMarks");
                });

            modelBuilder.Entity("_tiburon.Models.Respondent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Respondents");
                });

            modelBuilder.Entity("_tiburon.Models.Entities.RespondetnPhoneMark", b =>
                {
                    b.HasOne("_tiburon.Models.PhoneMark", "PhoneMark")
                        .WithMany("RespondetnPhoneMarks")
                        .HasForeignKey("PhoneMarkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_tiburon.Models.Respondent", "Respondent")
                        .WithMany("RespondetnPhoneMarks")
                        .HasForeignKey("RespondentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
