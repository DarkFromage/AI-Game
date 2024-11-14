using AI_Game.NPCs;
using AI_Game.Services;
using OllamaSharp;
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
        private IApiService ApiService;
        private string Start = "greet this person the way you see the fittest: ";


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
                //Chat chat = new Chat(OllamaAPIService.apiClient);

                while (true)
                {
                    var userInput = Console.ReadLine();
                    NpcResponse answer = await ApiService.GetNpcResponseAsync(ActualNpc.Name, userInput);
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
