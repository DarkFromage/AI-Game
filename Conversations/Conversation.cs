using AI_Game.NPCs;
using AI_Game.APIServices;
using OllamaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Game.Conversations
{
    public class Conversation
    {
        #region Fields

        private readonly INpc _actualNpc;
        private readonly IApiService _apiService;

        #endregion

        #region Constructors

        public Conversation(INpc actualNpc, IApiService apiService)
        {
            _actualNpc = actualNpc;
            _apiService = apiService;
        }

        #endregion

        #region Methods

        public async Task<string> GetResponseAsync(string userInput)
        {
            userInput = !string.IsNullOrEmpty(userInput) ? userInput : "Nice to meet you.";
            AgentResponse answer = await _apiService.GetAgentResponseAsync(_actualNpc.Name, userInput);
            return answer.Response;
        }

        #endregion
    }
}
