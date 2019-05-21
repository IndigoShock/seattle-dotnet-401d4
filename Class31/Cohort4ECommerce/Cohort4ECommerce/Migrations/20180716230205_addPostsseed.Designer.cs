﻿// <auto-generated />
using Cohort4ECommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cohort4ECommerce.Migrations
{
    [DbContext(typeof(CMSDbContext))]
    [Migration("20180716230205_addPostsseed")]
    partial class addPostsseed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cohort4ECommerce.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contents");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Posts");

                    b.HasData(
                        new { ID = 1, Contents = "Seriously, they are my best friends. They really know me.", Title = "My cats are my best friends" },
                        new { ID = 2, Contents = "Tacos make me happy, they are delicious. They make all the problems go away.", Title = "Tacos are Great" },
                        new { ID = 3, Contents = "Elsa is not a princess. She is a queen. Therefore better than all other princesses.", Title = "Disney Princess" },
                        new { ID = 4, Contents = "Dear Coffee, I love you. That is all.", Title = "Coffee is life" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
