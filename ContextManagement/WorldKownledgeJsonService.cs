using Newtonsoft.Json;

namespace AI_Game.ContextManagement
{
    public class WorldKownledgeJsonService
    {
        #region Fields

        private const string WORLDKNOWLEDGE_PATH = "WorldKnowledge.json";
        public Dictionary<string, string> worldKnowledge {  get; set; }

        #endregion

        #region Constructor

        public WorldKownledgeJsonService()
        {
            worldKnowledge = LoadWorldKnowledge();
        }

        #endregion

        private Dictionary<string, string> LoadWorldKnowledge()
        {
           string json = File.ReadAllText(WORLDKNOWLEDGE_PATH);

           return JsonConvert.DeserializeObject<Dictionary<string, string>>(json)??new Dictionary<string, string> { { " ", " " } };
        }

        public void SaveWorldKnowledge()
        {
            string json = JsonConvert.SerializeObject(worldKnowledge, Formatting.Indented);
            File.WriteAllText(WORLDKNOWLEDGE_PATH, json);
        }
    }
}
