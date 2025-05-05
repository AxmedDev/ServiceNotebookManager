using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;

namespace ServiceNotebook.API.ServiceRegistration
{
    public static class JwtRegistr
    {
        public static void RegistrJWT(this WebApplicationBuilder builder)
        {

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new() { Title = "LearnJWT API", Version = "v1" });

                // ?? JWT authentication üçün schema ?lav? olunur
                c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                    Description = "JWT token-i daxil edin. Format: Bearer {token}"
                });

                // ?? Bütün ?m?liyyatlara JWT t?l?bi ?lav? olunur (?g?r [Authorize] varsa)
                c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
                {
                   {
                   new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                   {
                       Reference = new Microsoft.OpenApi.Models.OpenApiReference
                       {
                           Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                           Id = "Bearer"
                       }
                   },
                   Array.Empty<string>()
               }
              });
            });




            builder.Services.AddAuthentication()
           .AddJwtBearer(options =>
           {
               var key = builder.Configuration["Jwt:Key"];
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ValidIssuer = builder.Configuration["Jwt:Issuer"],
                   ValidAudience = builder.Configuration["Jwt:Audience"],
                   IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(key))
               };

           });
        }
    }
}
