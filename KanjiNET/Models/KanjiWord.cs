using System;
using System.Text.Json.Serialization;

namespace KanjiNET.Models
{
    public class KanjiWord
    {
        [JsonPropertyName("variants")]
        public Variant[] Variants { get; set; }
        [JsonPropertyName("meanings")]
        public Meaning[] Meanings { get; set; }
    }

    public class Meaning
    {
        [JsonPropertyName("glosses")]
        public String[] Glosses { get; set; }
    }

    public class Variant
    {
        [JsonPropertyName("written")]
        public String Written { get; set; }
        [JsonPropertyName("pronounced")]
        public String Pronounced { get; set; }
        [JsonPropertyName("priorities")]
        public Object[] Priorities { get; set; }
    }
}