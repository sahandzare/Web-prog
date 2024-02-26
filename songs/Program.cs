using static WebApplication3.Data.IAnonymousEurosongDataList;
using WebApplication3.Data;

namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped(typeof(IAnonymousEurosongDataContext), typeof(AnonymousEurosongDataList));
            //Go for the singleton! 
            builder.Services.AddSingleton(typeof(IAnonymousEurosongDataContext), typeof(AnonymousEurosongDataList));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();

        }
    }
}