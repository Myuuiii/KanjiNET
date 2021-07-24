using System;
using System.Text.Json.Serialization;

namespace KanjiNET.Models
{
    public class KanjiReading
    {
        [JsonPropertyName("reading")]
        public String Reading { get; set; }
        [JsonPropertyName("main_kanji")]
        public String[] MainKanji { get; set; }
        [JsonPropertyName("name_kanji")]
        public String[] NameKanji { get; set; }
    }
}