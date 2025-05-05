using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer.Update.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ServiceNotebook.BLL.Services;
using ServiceNotebook.BLL.Services.TokenService;
using ServiceNotebook.Core.Repositories;
using ServiceNotebook.DAL.MyDbContext;
using ServiceNotebook.DAL.Repositories;
using ServiceNotebook.DAL.Repositories.Log;

namespace ServiceNotebook.BLL.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static void AddBusinessLayer(this IServiceCollection services)
        {
           
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ServiceNotebookDB>();
            services.AddScoped<IEmployeeNotebookRepository,EmployeeNotebookRepository>();
            services.AddScoped<EmployeeNotebookServices>();
            services.AddScoped<EducationService>();
            services.AddScoped<IEducationRepository,EducationRepository>();
            services.AddScoped<IAddressRepository,AddressRepository> ();
            services.AddScoped<AddressService>();
            services.AddScoped<AuditLogRepository>();
            services.AddScoped<IFamilyMemberRepository,FamilyMemberRepository>();
            services.AddScoped<FamilyMemberService>();
            services.AddScoped<TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<UserService>();
        }
    }
}
