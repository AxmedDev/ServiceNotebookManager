using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer.Update.Internal;
using Microsoft.Extensions.DependencyInjection;
using ServiceNotebook.BLL.Services;
using ServiceNotebook.Core.Repositories;
using ServiceNotebook.DAL.MyDbContext;
using ServiceNotebook.DAL.Repositories;

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

            

        }
    }
}
