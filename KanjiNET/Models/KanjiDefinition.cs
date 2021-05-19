using System;
using Newtonsoft.Json;

namespace KanjiNET.Models
{
    public class KanjiDefinition
    {
        [JsonProperty("kanji")]
        public String Kanji { get; set; }
        [JsonProperty("grade")]
        public Int32 Grade { get; set; }
        [JsonProperty("stroke_count")]
        public Int32 StrokeCount { get; set; }
        [JsonProperty("meanings")]
        public String[] Meanings { get; set; }
        [JsonProperty("kun_readings")]
        public String[] KunReadings { get; set; }
        [JsonProperty("on_readings")]
        public String[] OnReadings { get; set; }
        [JsonProperty("name_readings")]
        public String[] NameReadings { get; set; }
        [JsonProperty("jlpt")]
        public Int32 JlptLevel { get; set; }
        [JsonProperty("unicode")]
        public String Unicode { get; set; }
        [JsonProperty("heisig_en")]
        public String HeisigEN { get; set; }
    }
}