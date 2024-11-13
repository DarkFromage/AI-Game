using AI_Game.NPCs;
using AI_Game.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Game.Conversations
{
    internal class Conversation
    {
        #region Fields

        private INpc ActualNpc;
        private string Start = "greet this person the way you see the fittest: ";


        #endregion

        #region Constructors

        public Conversation(INpc actualNpc)
        {
            ActualNpc = actualNpc;
        }

        public async Task Talking() 
        {
            //string protagonistDescription = await NarratorMgn.Narrator.DescribeTheProtagonist();

            //await foreach (var answerToken in ActualNpc.Chat.Send(Start + protagonistDescription))
            //{
            //    Console.Write(answerToken);
            //}

            while (true)
            {
                NpcResponse answer = await ModelAPIService.GetNpcResponseAsync(ActualNpc.Name, "are you a mage from the conclave?");
                Console.WriteLine(answer.response);
            }
        }

        #endregion
    }
}
