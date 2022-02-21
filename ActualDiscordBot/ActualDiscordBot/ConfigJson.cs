﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActualDiscordBot
{
    public struct ConfigJson
    {
        [JsonProperty("token")]
        public string token { get; private set; }
        [JsonProperty("prefix")]
        public string Prefix { get; private set; }
    }
}
