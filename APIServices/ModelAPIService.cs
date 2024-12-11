using System.Net.Http.Json;
using AI_Game.NPCs;

namespace AI_Game.APIServices
{
    public class ModelAPIService : IApiService
    {
        #region Fields

        private readonly static Uri uri = new Uri("http://localhost:8000");
        private readonly static HttpClient client = new HttpClient();

        #endregion

        public async Task<AgentResponse> GetAgentResponseAsync(string npcName, string prompt)
        {
            var endpoint = $"{uri}npc/{npcName}";
            var requestData = new { prompt };
            var response = await client.PostAsJsonAsync(endpoint, requestData);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<AgentResponse>();
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error: {response.StatusCode}, {errorMessage}");
            }
        }
    }
}
