namespace AI_Game.NPCs
{
    internal class Npc : INpc
    {
        public string Name { get; private set; }

        public Npc(string name) 
        {
            Name = name;
        }
    }
}