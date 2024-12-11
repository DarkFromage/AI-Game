using AI_Game.Conversations;
using AI_Game.NPCs;
using AI_Game.APIServices;
using OllamaSharp;
using AI_Game.ContextManagement;

namespace AI_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var isOllama = true;

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<INpc, Draven>();
            builder.Services.AddScoped<IContextAgent, ContextAgent>();
            if (isOllama == false)
            {
                builder.Services.AddScoped<IApiService, ModelAPIService>();
            }
            else
            {
                builder.Services.AddScoped<IApiService, OllamaAPIService>();
            }

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
                    c.RoutePrefix = string.Empty;
                });
            }

            app.MapControllers();

            app.Run();
        }
    }
}
