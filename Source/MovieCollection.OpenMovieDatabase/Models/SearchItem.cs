﻿using MovieCollection.OpenMovieDatabase.Enums;
using Newtonsoft.Json;

namespace MovieCollection.OpenMovieDatabase.Models
{
    public class SearchItem
    {
        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Year")]
        public string Year { get; set; }

        [JsonProperty("imdbID")]
        public string ImdbId { get; set; }

        [JsonProperty("Type")]
        public MovieType Type { get; set; }

        [JsonProperty("Poster")]
        public string Poster { get; set; }
    }
}
