﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("WebApplication1.Models.Assignee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AssigneeDatabase");
                });

            modelBuilder.Entity("WebApplication1.ToDo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("AssigneeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDone")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsUrgent")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId");

                    b.ToTable("ToDoDatabase");
                });

            modelBuilder.Entity("WebApplication1.ToDo", b =>
                {
                    b.HasOne("WebApplication1.Models.Assignee", "Assignee")
                        .WithMany("AssigneeToDos")
                        .HasForeignKey("AssigneeId");

                    b.Navigation("Assignee");
                });

            modelBuilder.Entity("WebApplication1.Models.Assignee", b =>
                {
                    b.Navigation("AssigneeToDos");
                });
#pragma warning restore 612, 618
        }
    }
}
