using AI_Game.NPCs;
using OllamaSharp;



namespace AI_Game.Services
{
    internal class OllamaAPIService : IApiService
    {
        private static readonly Uri uri = new Uri("http://localhost:11434");
        private static readonly string modelName = "llama3.2";
        public static readonly OllamaApiClient apiClient = new(uri, modelName);
        private readonly Chat chat = new Chat(apiClient);
        

        public async Task<NpcResponse> GetNpcResponseAsync(string npcName, string prompt)
        {
            var response = new NpcResponse() {NpcName = npcName, Response = ""};

            await foreach (var answerToken in chat.Send(prompt))
            {
                response.Response += answerToken;
            }

            return response;
        }
    }
}
