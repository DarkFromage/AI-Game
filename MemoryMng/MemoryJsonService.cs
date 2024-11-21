﻿using Newtonsoft.Json;

namespace AI_Game.MemoryMng
{
    internal class MemoryJsonService
    {
        #region Fields

        private const string MEMORY_PATH = "Memory.json";
        public required Dictionary<string, Dictionary<string, string>> memory;

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
