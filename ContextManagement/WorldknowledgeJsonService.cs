using Newtonsoft.Json;

namespace AI_Game.ContextManagement
{
    public class WorldknowledgeJsonService
    {
        #region Fields

        private const string KNOWLEDEGE_PATH = "Knowledge.json";

        #endregion

        #region Constructor

        public WorldknowledgeJsonService()
        {
            Knowledge = Loadknowledge();
        }

        #endregion


        #region Methods

        private Dictionary<string, Dictionary<string, string>> Loadknowledge()
        {
            if (!File.Exists(KNOWLEDEGE_PATH)) return new Dictionary<string, Dictionary<string, string>>();

            string json = File.ReadAllText(KNOWLEDEGE_PATH);

            return JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json) ?? new Dictionary<string, Dictionary<string, string>>();
        }

        public void SaveMemory()
        {
            string json = JsonConvert.SerializeObject(Knowledge, Formatting.Indented);
            File.WriteAllText(KNOWLEDEGE_PATH, json);
        }

        #endregion

        #region Properties

        public Dictionary<string, Dictionary<string, string>> Knowledge { get; set; }
        // memory: {NPC-name, { #, memory}} // in the future --> {session,{NPC-name, { #, memory}}} one session number will be for the things that are accessible to all.
        // 

        #endregion
    }
}
