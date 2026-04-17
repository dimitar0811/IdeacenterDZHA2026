using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace IdeaCenterDZHA.Models
{
    internal class ApiResponseDTO
    {
        [JsonPropertyName("msg")]

        public string? Msg { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}
