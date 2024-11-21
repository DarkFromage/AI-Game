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
            IApiService apiService;
            Console.WriteLine("Please Choose your ApiService:\n1. OllamaApiService.\n2. ModelApiService.");
            var answer = Console.ReadLine();
            if (answer == "2")
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
