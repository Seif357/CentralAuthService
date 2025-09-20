
using Api;
using Scalar.AspNetCore;

namespace CentralAuthService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddScoped<IUserRepository,UserRepository>();
            builder.Services.AddScoped<IUserService,UsersService>();

            var app = builder.Build();
            app.UsePathBase("/Scalar");
            app.MapGet("/", () => Results.Redirect("/Scalar", permanent: true));
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }
            if (!app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }

            app.UseHttpsRedirection();
            app.UseRouting()
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
