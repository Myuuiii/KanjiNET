using System;
using System.Text.Json.Serialization;

namespace KanjiNET.Models
{
    public class KanjiResult<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public Boolean Success { get; set; }
        [JsonIgnore]
        public String Exception { get; set; }
    }
}