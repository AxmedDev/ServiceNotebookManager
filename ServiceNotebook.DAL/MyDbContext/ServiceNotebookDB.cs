using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceNotebook.Core.Entities;

namespace ServiceNotebook.DAL.MyDbContext
{
    public  class ServiceNotebookDB : DbContext
    {
        public DbSet<EmployeeNotebook> EmployeeNotebooks { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CombatParticipation> CombatParticipations { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<FamilyMember> FamilyMembers { get; set; }
        public DbSet<ForeignLanguage> ForeignLanguages { get; set; }
        public DbSet<HealthStatus> HealthStatuses { get; set; }
        public DbSet<IdentificationDocument> IdentificationDocuments { get; set; }
        public DbSet<MilitaryService> MilitaryServices { get; set; }
        public DbSet<Order> Orders {  get; set; }
        public DbSet<SkillDegree> SkillDegrees { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BJP5580;Initial Catalog=ServiceNotebookDB;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Education>().HasIndex(x => x.DiplomaNumber).IsUnique();
            modelBuilder.Entity<EmployeeNotebook>().HasIndex(x=>x.MainPhoneNumber).IsUnique();
            modelBuilder.Entity<IdentificationDocument>().HasIndex(x=>x.DocumentNumber).IsUnique();
            modelBuilder.Entity<Order>().HasIndex(x=> x.OrderNumber).IsUnique();    
        }

    }
}
