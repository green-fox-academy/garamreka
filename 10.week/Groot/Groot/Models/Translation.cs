using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Groot.Models
{
    public class Translation : IGuardian
    {
        [JsonProperty("received")]
        public string Received { get; set; }
        [JsonProperty("response")]
        public string Response { get; set; } = "I am Groot!";
    }
}
