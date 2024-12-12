namespace AI_Game.NPCs
{
    public interface INpc
    {
        string Name { get; }
        string Personality { get; } // Should be removed when the training is completed
    }
}
