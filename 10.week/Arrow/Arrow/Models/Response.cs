using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrow.Models
{
    public class Response : IArrow
    {
        [JsonProperty("time")]
        public double? Time { get; set; }
        [JsonProperty("distance")]
        public double? Distance { get; set; }
        [JsonProperty("speed")]
        public double? Speed { get; set; }
    }
}
