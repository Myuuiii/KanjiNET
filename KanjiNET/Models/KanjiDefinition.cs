using System;
using System.Text.Json.Serialization;

namespace KanjiNET.Models
{
    public class KanjiDefinition
    {
        [JsonPropertyName("kanji")]
        public String Kanji { get; set; }
        [JsonPropertyName("grade")]
        public Int32 Grade { get; set; }
        [JsonPropertyName("stroke_count")]
        public Int32 StrokeCount { get; set; }
        [JsonPropertyName("meanings")]
        public String[] Meanings { get; set; }
        [JsonPropertyName("kun_readings")]
        public String[] KunReadings { get; set; }
        [JsonPropertyName("on_readings")]
        public String[] OnReadings { get; set; }
        [JsonPropertyName("name_readings")]
        public String[] NameReadings { get; set; }
        [JsonPropertyName("jlpt")]
        public Int32 JlptLevel { get; set; }
        [JsonPropertyName("unicode")]
        public String Unicode { get; set; }
        [JsonPropertyName("heisig_en")]
        public String HeisigEN { get; set; }
    }
}