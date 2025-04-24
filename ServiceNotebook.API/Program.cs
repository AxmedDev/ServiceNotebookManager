
using System.Reflection;
using Serilog;
using ServiceNotebook.API.Middlewares;
using ServiceNotebook.BLL.ServiceRegistration;

namespace ServiceNotebook.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            Log.Logger = new LoggerConfiguration()
            .WriteTo.File(@"C:\Users\User\Desktop\MyLogs\log-.txt", rollingInterval: RollingInterval.Minute)
            .CreateLogger();
            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddBusinessLayer();

            builder.Host.UseSerilog();
            var app = builder.Build();

            app.UseMiddleware<ExceptionHandleMiddleware>();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
  

            app.MapControllers();

            app.Run();
        }
    }
}
