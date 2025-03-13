using System.Text.Json.Serialization;

namespace DotnetLibExample.App.Models
{
    public class GetBreedResponse
    {
        [JsonPropertyName("message")]
        public Dictionary<string, List<string>> Message { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}