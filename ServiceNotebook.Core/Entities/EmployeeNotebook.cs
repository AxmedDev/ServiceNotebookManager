using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities
{
    public class EmployeeNotebook : BaseEntity
    {
        public string Name  { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public DateTime Birthday { get; set; }
        public string Citizenship { get; set; }
        public string Nationality { get; set; }
        public bool IsMarried { get; set; }
        public string MainPhoneNumber { get; set; }
        public string OtherPhoneNumber { get; set; } = null;
        public string Email {  get; set; }=null;


        #region OneToMany
        public List<Education> Educations { get; set; } = new List<Education>();
        public List<MilitaryService> MilitaryServices { get; set; } = new List<MilitaryService>();
        public List<CombatParticipation> CombatParticipations { get; set; } = new List<CombatParticipation>();
        public List<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
        public List<ForeignLanguage> ForeignLanguages { get; set; } = new List<ForeignLanguage>();
        public List<SkillDegree> SkillDegrees { get; set; } = new List<SkillDegree>();
        public List<FamilyMember> FamilyMembers { get; set; } = new List<FamilyMember>();
        public List<HealthStatus> HealthStatuses { get; set; } = new List<HealthStatus>();
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Address> Addresss { get; set; }= new List<Address>();
        public List<IdentificationDocument> IdentificationDocuments { get; set; }= new List<IdentificationDocument>();
        #endregion

    }
}
