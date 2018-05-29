﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models
{
    public class PlayerGameLogsResponse
    {
        [JsonProperty("playergamelogs")]
        public Playergamelogs PlayerGameLogs { get; set; }
    }
    
    public class Gamelog
    {
        [JsonProperty("game")]
        public Game Game { get; set; }

        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("stats")]
        public GameLogStats Stats { get; set; }
    }

    public class Playergamelogs
    {
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        [JsonProperty("gamelogs")]
        public List<Gamelog> GameLogs { get; set; }
    }
}