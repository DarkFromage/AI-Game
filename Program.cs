using AI_Game.Conversations;
using AI_Game.NPCs;
using AI_Game.APIServices;
using OllamaSharp;

namespace AI_Game
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            IApiService apiService;
            var isOllama = true;

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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

            if (isOllama == false)
            {
                apiService = new ModelAPIService();
            }
            else 
            {
                apiService = new OllamaAPIService();
            }

            INpc draven = new Npc("base");

            Conversation conversation = new(draven, apiService);
            await conversation.Talking();
        }
    }
}
