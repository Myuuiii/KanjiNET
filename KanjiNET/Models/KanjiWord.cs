using System;
using Newtonsoft.Json;

namespace KanjiNET.Models
{
    public class KanjiWord
    {
        [JsonProperty("variants")]
        public Variant[] Variants { get; set; }
        [JsonProperty("meanings")]
        public Meaning[] Meanings { get; set; }
    }

    public class Meaning
    {
        [JsonProperty("glosses")]
        public String[] Glosses { get; set; }
    }

    public class Variant
    {
        [JsonProperty("written")]
        public String Written { get; set; }
        [JsonProperty("pronounced")]
        public String Pronounced { get; set; }
        [JsonProperty("priorities")]
        public Object[] Priorities { get; set; }
    }
}