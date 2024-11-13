using AI_Game.NPCs;
using OllamaSharp;



namespace AI_Game.Services
{
    internal class OllamaAPIService : IApiService
    {
        private static readonly Uri uri = new Uri("http://localhost:11434");
        public static readonly OllamaApiClient apiClient = new(uri);


        public async Task<NpcResponse> GetNpcResponseAsync(string npcName, string prompt)
        {
            Chat chat = new Chat(apiClient);
            
        }
    }
}
