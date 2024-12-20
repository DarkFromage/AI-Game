﻿using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

namespace AI_Game.ContextManagement
{
    public class MemoryJsonService
    {
        #region Fields

        private const string MEMORY_PATH = "Memory.json";

        #endregion

        #region Constructor

        public MemoryJsonService()
        {
            memory = LoadMemory();
        }

        #endregion


        #region Methods

        private Dictionary<string, Dictionary<string, string>> LoadMemory()
        {
            if (!File.Exists(MEMORY_PATH)) return new Dictionary<string, Dictionary<string, string>>();

            string json = File.ReadAllText(MEMORY_PATH);

            return JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json) ?? new Dictionary<string, Dictionary<string, string>>();
        }

        public void SaveMemory()
        {
            string json = JsonConvert.SerializeObject(memory, Formatting.Indented);
            File.WriteAllText(MEMORY_PATH, json);
        }

        #endregion

        #region Properties

        public Dictionary<string, Dictionary<string, string>> memory { get; set; }
        // memory: {NPC-name, { #, memory}} // in the future --> {session,{NPC-name, { #, memory}}} one session number will be for the things that are accessible to all.
        // 

        #endregion
    }
}
