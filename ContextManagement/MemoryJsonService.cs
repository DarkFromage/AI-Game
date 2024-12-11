using Newtonsoft.Json;

namespace AI_Game.ContextManagement
{
    public class MemoryJsonService
    {
        #region Fields

        private const string MEMORY_PATH = "Memory.json";
        public Dictionary<string, Dictionary<string, string>> memory {  get; set; }

        #endregion

        #region Constructor

        public MemoryJsonService()
        {
            memory = LoadMemory();
        }

        #endregion

        private Dictionary<string, Dictionary<string, string>> LoadMemory()
        {
            string json = File.ReadAllText(MEMORY_PATH);

            return JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json) ?? new Dictionary<string, Dictionary<string, string>> { { " ", new Dictionary<string, string> { { " ", " " } } } };
        }

        public void SaveMemory()
        {
            string json = JsonConvert.SerializeObject(memory, Formatting.Indented);
            File.WriteAllText(MEMORY_PATH, json);
        }
    }
}
