using Newtonsoft.Json;

namespace AI_Game.ContextManagement
{
    public class PastExchangesSummaryJsonService
    {
        #region Fields

        private const string SUMMARY_PATH = "Summary.json";

        public Dictionary<string, string> Summary { get; set; }

        #endregion

        #region Constructor

        public PastExchangesSummaryJsonService()
        {
            Summary = LoadSummary();
        }

        #endregion

        private Dictionary<string, string> LoadSummary()
        {
            if (!File.Exists(SUMMARY_PATH)) return new Dictionary<string, string>();

            string json = File.ReadAllText(SUMMARY_PATH);

            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
        }

        public void SaveMemory()
        {
            string json = JsonConvert.SerializeObject(Summary, Formatting.Indented);
            File.WriteAllText(SUMMARY_PATH, json);
        }
    }
}

