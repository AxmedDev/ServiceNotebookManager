using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceNotebook.Core.Entities;
using ServiceNotebook.Core.Entities.Log;

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

        public DbSet<AuditLog> AuditLogs { get; set; }

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

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var auditLogs = new List<AuditLog>();

            var entries = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified || e.State == EntityState.Deleted);

            foreach (var entry in entries)
            {
                var tableName = entry.Entity.GetType().Name;
                var primaryKey = entry.Properties.FirstOrDefault(p => p.Metadata.IsPrimaryKey())?.CurrentValue?.ToString();

                
                if (entry.State == EntityState.Modified)
                {
                    foreach (var prop in entry.Properties)
                    {
                        if (prop.IsModified)
                        {
                            var oldValue = prop.OriginalValue?.ToString() ?? "null";
                            var newValue = prop.CurrentValue?.ToString() ?? "null";

                            if (oldValue != newValue)
                            {
                                auditLogs.Add(new AuditLog
                                {
                                    TableName = tableName,
                                    PrimaryKey = primaryKey,
                                    OperationType = "Modified",
                                    ColumnName = prop.Metadata.Name,
                                    OldValue = oldValue,
                                    NewValue = newValue,
                                    Date = DateTime.Now
                                });
                            }
                        }
                    }
                }
            }

          
            AuditLogs.AddRange(auditLogs);

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
