﻿using System.Net.Http.Json;
using AI_Game.NPCs;

namespace AI_Game.Services
{
    internal static class ModelAPIService
    {
        #region Fields

        private readonly static Uri uri = new Uri("http://localhost:8000");
        private readonly static HttpClient client = new HttpClient();

        #endregion

        public static async Task<NpcResponse> GetNpcResponseAsync(string npcName, string prompt)
        {
            // Create the endpoint URL with the NPC name
            var endpoint = $"{uri}npc/{npcName}";

            // Prepare the request content
            var requestData = new { prompt = prompt };

            // Send the POST request
            var response = await client.PostAsJsonAsync(endpoint, requestData);

            // Handle the response
            if (response.IsSuccessStatusCode)
            {
                // Parse and return the response as NpcResponse object
                return await response.Content.ReadFromJsonAsync<NpcResponse>();
            }
            else
            {
                // Handle errors (e.g., NPC not found, server error)
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error: {response.StatusCode}, {errorMessage}");
            }
        }
    }
}