﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceNotebook.DAL.MyDbContext;

#nullable disable

namespace ServiceNotebook.DAL.Migrations
{
    [DbContext(typeof(ServiceNotebookDB))]
    partial class ServiceNotebookDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeNotebookOrder", b =>
                {
                    b.Property<int>("EmployeeNotebooksId")
                        .HasColumnType("int");

                    b.Property<int>("OrdersId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeNotebooksId", "OrdersId");

                    b.HasIndex("OrdersId");

                    b.ToTable("EmployeeNotebookOrder");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeNotebookId")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeNotebookId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.CombatParticipation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeNotebookId")
                        .HasColumnType("int");

                    b.Property<string>("Injuries")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ParticipationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VeteranStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeNotebookId");

                    b.ToTable("CombatParticipations");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DiplomaDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiplomaNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EducationLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeNotebookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Faculty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstitutionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DiplomaNumber")
                        .IsUnique();

                    b.HasIndex("EmployeeNotebookId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.EmployeeNotebook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Citizenship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMarried")
                        .HasColumnType("bit");

                    b.Property<string>("MainPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainPhoneNumber")
                        .IsUnique();

                    b.ToTable("EmployeeNotebooks");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.FamilyMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeNotebookId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relationship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeNotebookId");

                    b.ToTable("FamilyMembers");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.ForeignLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeNotebookId")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProficiencyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeNotebookId");

                    b.ToTable("ForeignLanguages");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.HealthStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeNotebookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExaminationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MedicalInstitution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceSuitability")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeNotebookId");

                    b.ToTable("HealthStatuses");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.IdentificationDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BloodType")
                        .HasColumnType("int");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DocumentType")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeNotebookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IssuingAuthority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentNumber")
                        .IsUnique();

                    b.HasIndex("EmployeeNotebookId");

                    b.ToTable("IdentificationDocuments");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.Log.AuditLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ColumnName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("NewValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuditLogs");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.MilitaryService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AssignmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeNotebookId")
                        .HasColumnType("int");

                    b.Property<int>("MilitaryRank")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeNotebookId");

                    b.HasIndex("OrderId");

                    b.ToTable("MilitaryServices");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderNumber")
                        .IsUnique();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.Register.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.SkillDegree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AssignmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeNotebookId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeNotebookId");

                    b.HasIndex("OrderId");

                    b.ToTable("SkillDegrees");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.WorkExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeNotebookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Workplace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeNotebookId");

                    b.ToTable("WorkExperiences");
                });

            modelBuilder.Entity("EmployeeNotebookOrder", b =>
                {
                    b.HasOne("ServiceNotebook.Core.Entities.EmployeeNotebook", null)
                        .WithMany()
                        .HasForeignKey("EmployeeNotebooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceNotebook.Core.Entities.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.Address", b =>
                {
                    b.HasOne("ServiceNotebook.Core.Entities.EmployeeNotebook", "EmployeeNotebook")
                        .WithMany("Addresss")
                        .HasForeignKey("EmployeeNotebookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeNotebook");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.CombatParticipation", b =>
                {
                    b.HasOne("ServiceNotebook.Core.Entities.EmployeeNotebook", "EmployeeNotebook")
                        .WithMany("CombatParticipations")
                        .HasForeignKey("EmployeeNotebookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeNotebook");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.Education", b =>
                {
                    b.HasOne("ServiceNotebook.Core.Entities.EmployeeNotebook", "EmployeeNotebook")
                        .WithMany("Educations")
                        .HasForeignKey("EmployeeNotebookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeNotebook");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.FamilyMember", b =>
                {
                    b.HasOne("ServiceNotebook.Core.Entities.EmployeeNotebook", "EmployeeNotebook")
                        .WithMany("FamilyMembers")
                        .HasForeignKey("EmployeeNotebookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeNotebook");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.ForeignLanguage", b =>
                {
                    b.HasOne("ServiceNotebook.Core.Entities.EmployeeNotebook", "EmployeeNotebook")
                        .WithMany("ForeignLanguages")
                        .HasForeignKey("EmployeeNotebookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeNotebook");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.HealthStatus", b =>
                {
                    b.HasOne("ServiceNotebook.Core.Entities.EmployeeNotebook", "EmployeeNotebook")
                        .WithMany("HealthStatuses")
                        .HasForeignKey("EmployeeNotebookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeNotebook");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.IdentificationDocument", b =>
                {
                    b.HasOne("ServiceNotebook.Core.Entities.EmployeeNotebook", "EmployeeNotebook")
                        .WithMany("IdentificationDocuments")
                        .HasForeignKey("EmployeeNotebookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeNotebook");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.MilitaryService", b =>
                {
                    b.HasOne("ServiceNotebook.Core.Entities.EmployeeNotebook", "EmployeeNotebook")
                        .WithMany("MilitaryServices")
                        .HasForeignKey("EmployeeNotebookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceNotebook.Core.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeNotebook");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.SkillDegree", b =>
                {
                    b.HasOne("ServiceNotebook.Core.Entities.EmployeeNotebook", "EmployeeNotebook")
                        .WithMany("SkillDegrees")
                        .HasForeignKey("EmployeeNotebookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceNotebook.Core.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeNotebook");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.WorkExperience", b =>
                {
                    b.HasOne("ServiceNotebook.Core.Entities.EmployeeNotebook", "EmployeeNotebook")
                        .WithMany("WorkExperiences")
                        .HasForeignKey("EmployeeNotebookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeNotebook");
                });

            modelBuilder.Entity("ServiceNotebook.Core.Entities.EmployeeNotebook", b =>
                {
                    b.Navigation("Addresss");

                    b.Navigation("CombatParticipations");

                    b.Navigation("Educations");

                    b.Navigation("FamilyMembers");

                    b.Navigation("ForeignLanguages");

                    b.Navigation("HealthStatuses");

                    b.Navigation("IdentificationDocuments");

                    b.Navigation("MilitaryServices");

                    b.Navigation("SkillDegrees");

                    b.Navigation("WorkExperiences");
                });
#pragma warning restore 612, 618
        }
    }
}
