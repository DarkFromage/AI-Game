using AI_Game.APIServices;
using AI_Game.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Game.ContextManagement
{
    public class ContextAgent : IContextAgent
    {
        private readonly MemoryJsonService memoryJsonService;
        private WorldKownledgeJsonService worldKownledgeJsonService;
        private IApiService apiService;
        private readonly string instructions = "";
        private readonly string AgentName = "ContextAgent";



        public ContextAgent(IApiService apiService) 
        {
            memoryJsonService = new();
            worldKownledgeJsonService = new();
            this.apiService = apiService;
        }

        public string GetContext(string npcName, string prompt)
        {
            //bool formatIsRight = false;
            //string Agentprompt = instructions + "";

            //while (!formatIsRight)
            //{
            //    apiService.GetAgentResponseAsync(AgentName, Agentprompt);
            //}


            return prompt;
        }


    }
}
