using FoodDeliveryApp.DataLayers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text.Json.Serialization;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using FoodDeliveryApp.Mappings;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configure DbContext
        builder.Services.AddDbContext<FoodDeliveryAppDb>(opts =>
            opts.UseSqlServer(builder.Configuration.GetConnectionString("FoodDeliveryAppDb")));

        // Configure JSON options
        builder.Services.AddControllers().AddJsonOptions(opts =>
            opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

        // Configure Swagger
        builder.Services.AddSwaggerGen();

        // Configure AutoMapper
        builder.Services.AddAutoMapper(typeof(MappingProfile));

        // Configure CORS
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAllOrigins",
                builder => builder.AllowAnyOrigin()
                                  .AllowAnyMethod()
                                  .AllowAnyHeader());
        });

        // Configure JWT Authentication
        var key = Encoding.ASCII.GetBytes("YourSuperSecretKeyHere");
        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "yourIssuer",
                    ValidAudience = "yourAudience",
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };
            });

        var app = builder.Build();

        // Middleware
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "FoodDelivery API V1");
            });
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseCors("AllowAllOrigins");

        app.UseAuthentication(); // Ensure this is added
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
