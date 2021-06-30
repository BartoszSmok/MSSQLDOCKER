using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MSSQLDOCKER
{
    public class TestEntry
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        public string testText { get; set; }
    }
}
