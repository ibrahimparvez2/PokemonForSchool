using System.Collections.Generic;
using Newtonsoft.Json;

namespace RestaurantLocater.Models
{
    public class SpeciesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("flavor_text_entries")] 
        public List<FlavorTextEntry> Description { get; set; }
    }
      public class Language    {
        public string name { get; set; } 
        public string url { get; set; } 
    }

    public class Version    {
        public string name { get; set; } 
        public string url { get; set; } 
    }


    public class FlavorTextEntry    {
        
        [JsonProperty("flavor_text")] 
        public string Text { get; set; } 
        public Language language { get; set; } 
        public Version version { get; set; } 
    }

}