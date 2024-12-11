using AI_Game.NPCs;

namespace AI_Game.ContextManagement
{
    public interface IContextAgent
    {
        public string GetContext(string npcName, string prompt);
    }
}
