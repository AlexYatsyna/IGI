using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WEB_953506_YATSYNA.Blazor.Client.Models
{
    public class DetailsViewModel
    {
        [JsonPropertyName("dishName")]
        public string DishName { get; set; } 
        [JsonPropertyName("description")]
        public string Description { get; set; } 
        [JsonPropertyName("calories")]
        public int Calories { get; set; } 
        [JsonPropertyName("image")]
        public string Image { get; set; } 
    }
}
