﻿// <auto-generated />
using System;
using FundooRepository.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FundooRepository.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Common.Models.AdminModels.AdminLoginModel", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.HasKey("Email");

                    b.ToTable("AdminLogin");
                });

            modelBuilder.Entity("Common.Models.AdminModels.AdminModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("LoginTime");

                    b.Property<string>("Service");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Common.Models.CollaboratorModel.NotesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("Images");

                    b.Property<int>("IndexValue");

                    b.Property<bool>("IsArchive");

                    b.Property<bool>("IsPin");

                    b.Property<bool>("IsTrash");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Reminder");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Common.Models.CollaboratorsModels.CollaboratorsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NoteId");

                    b.Property<string>("ReciverEmail");

                    b.Property<string>("SenderEmail");

                    b.HasKey("Id");

                    b.ToTable("Collaborators");
                });

            modelBuilder.Entity("Common.Models.LabelModels.LabelModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("Common.Models.NotesLabelsModels.NoteLabelModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label");

                    b.Property<int>("LableId");

                    b.Property<int>("NoteId");

                    b.HasKey("Id");

                    b.ToTable("NotesLabelModels");
                });

            modelBuilder.Entity("Common.Models.UserModel", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CardType");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("ProfilePicture");

                    b.Property<string>("Status");

                    b.Property<int>("TotalNotes");

                    b.HasKey("Email");

                    b.ToTable("Register");
                });
#pragma warning restore 612, 618
        }
    }
}
