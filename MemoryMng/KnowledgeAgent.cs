using AI_Game.APIServices;
using AI_Game.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Game.MemoryMng
{
    internal class KnowledgeAgent
    {
        private readonly MemoryJsonService memoryJsonService;
        private WorldKownledgeJsonService worldKownledgeJsonService;
        private IApiService apiService;
        private readonly string instructions = "";
        private readonly string AgentName = "KnowledgeAgent";



        public KnowledgeAgent(IApiService api) 
        {
            memoryJsonService = new();
            worldKownledgeJsonService = new();
            apiService = api;
        }

        public string GetKnowledgeAndMemories(string npcName, string prompt)
        {
            bool formatIsRight = false;
            string Agentprompt = instructions + "";

            while (!formatIsRight)
            {
                apiService.GetAgentResponseAsync(AgentName, Agentprompt);
            }


            return prompt;
        }


    }
}
