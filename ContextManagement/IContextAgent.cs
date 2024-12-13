using AI_Game.NPCs;

namespace AI_Game.ContextManagement
{
    public interface IContextAgent
    {
        Task GetContext(string npcName, string prompt);
    }
}
