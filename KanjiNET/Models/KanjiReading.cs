using System;
using Newtonsoft.Json;

namespace KanjiNET.Models
{
    public class KanjiReading
    {
        [JsonProperty("reading")]
        public String Reading { get; set; }
        [JsonProperty("main_kanji")]
        public String[] MainKanji { get; set; }
        [JsonProperty("name_kanji")]
        public String[] NameKanji { get; set; }
    }
}