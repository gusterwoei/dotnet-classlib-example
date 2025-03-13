using System.Text.Json.Serialization;

namespace DotnetLibExample.Lib.Models
{
    public class GetSubBreedResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("message")]
        public List<string> Message { get; set; }

    }
}