using AI_Game.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Game.APIServices
{
    public interface IApiService
    {
        Task<AgentResponse> GetAgentResponseAsync(string agent, string prompt);
    }
}
