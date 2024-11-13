namespace AI_Game.NPCs
{
    internal class Npc : INpc
    {
        public string Name { get; private set; }
        public string Chat { get; private set; }

        public Npc(string name, string chat) 
        {
            Name = name;
            Chat = chat;
        }
    }
}
