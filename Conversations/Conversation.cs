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
    internal class Conversation
    {
        #region Fields

        private INpc ActualNpc;
        private IApiService ApiService;


        #endregion

        #region Constructors

        public Conversation(INpc actualNpc, IApiService apiService)
        {
            ActualNpc = actualNpc;
            ApiService = apiService;
        }

        #endregion

        #region Methods

        public async Task Talking() 
        {
               

                while (true)
                {
                    var userInput = Console.ReadLine();
                    userInput = userInput != null && userInput != string.Empty ? userInput : "Nice to meet you.";
                    AgentResponse answer = await ApiService.GetAgentResponseAsync(ActualNpc.Name, userInput);
                    Console.WriteLine(answer.Response);
                }

           
            //string protagonistDescription = await NarratorMgn.Narrator.DescribeTheProtagonist();

            //await foreach (var answerToken in ActualNpc.Chat.Send(Start + protagonistDescription))
            //{
            //    Console.Write(answerToken);
            //}
        }

        #endregion
    }
}
