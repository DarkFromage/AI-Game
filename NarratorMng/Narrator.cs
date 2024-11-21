using AI_Game.APIServices;
using OllamaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Game.NarratorMgn
{
    //internal static class Narrator
    //{
    //    private readonly static OllamaApiClient narratorClient  = new OllamaApiClient(ModelAPIService.uri);
    //    private static Chat narrator;

    //    //For Testing
    //    private static string ProtagonistLook = "A tall figure strides forward, clad in a long, dust-streaked leather coat that sways with each step. His eyes, a sharp green, gleam beneath the brim of a wide-brimmed hat pulled low, casting shadows across his weathered face. A jagged scar traces down one cheek, adding to his rugged appearance, while a silver earring catches the light as he moves. His boots, worn and scuffed, show signs of long journeys, and a sword with intricate runes rests at his hip, ready for whatever lies ahead.";

    //    static Narrator()
    //    {
    //        narratorClient.SelectedModel = "mistral-openorca";
    //        narrator = new Chat(narratorClient);
    //    }


    //    public static async Task<string> DescribeTheProtagonist() {

    //        string description = string.Empty;
    //        await foreach (var answerToken in narrator.Send("Describe this person to someone: " + ProtagonistLook))
    //        {
    //            description += answerToken;
    //        }
    //        return description;
    //    }
    //}
}
