using AI_Game.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Game.Services
{
    internal interface IApiService
    {
        Task<NpcResponse> GetNpcResponseAsync(string npcName, string prompt);
    }
}
