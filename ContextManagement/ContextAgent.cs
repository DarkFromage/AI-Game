using AI_Game.APIServices;
using AI_Game.NPCs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Game.ContextManagement
{
    public class ContextAgent : IContextAgent
    {
        private readonly MemoryJsonService memoryJsonService;
        private WorldknowledgeJsonService worldKownledgeJsonService;
        private IApiService apiService;
        private readonly string instructions = "Objective:\nYour task is to identify the most relevant keywords from a provided list. " +
            "These hashtags correspond to keys in a dictionary, which will retrieve the appropriate values for the NPC to respond meaningfully during the interaction." +
            "\n";
        private readonly string AgentName = "ContextAgent";



        public ContextAgent(IApiService apiService) 
        {
            memoryJsonService = new();
            worldKownledgeJsonService = new();
            this.apiService = apiService;
        }

        public async Task<String> GetContext(string npcName, string prompt)
        {
            // the prompt and the npc need to give multiple informations (so they have to be more than strings): how does the NPC feels about the PC, its personnality, role and knowledge etc. from the PC we need to have his descrition.
            // search for knowledge needed in this exchange
            var tagList = new List<string>();
            if (memoryJsonService.memory.Keys.Contains(npcName))
            {
                foreach (string k in memoryJsonService.memory.Keys)
                {
                    tagList.Add(k);
                }
            }

            if (worldKownledgeJsonService.Knowledge.Keys.Contains(npcName))
            {
                foreach (string k in worldKownledgeJsonService.Knowledge.Keys)
                {
                    tagList.Add(k);
                }
            }

            // add the summary of past exchanges
            // update the knowledge if necessary
            // update the summary



            return prompt;
        }


    }
}
