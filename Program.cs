using AI_Game.Conversations;
using AI_Game.NPCs;
using AI_Game.Services;
using OllamaSharp;

namespace AI_Game
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            INpc draven = new Npc("base", "ok");
            Conversation conversation = new(draven);
            await conversation.Talking();
        }
    }
}
