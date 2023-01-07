using System.Text.Json.Serialization;

namespace JokeApp
{
    public class Joke
    {
        [property: JsonPropertyName("error")]
        public bool Error { get; set; }
        [property: JsonPropertyName("category")]
        public string? Category { get; set; }
        [property: JsonPropertyName("type")]
        public string? Type { get; set; }
        [property: JsonPropertyName("setup")]
        public string? Setup { get; set; }
        [property: JsonPropertyName("delivery")]
        public string? Delivery { get; set; }
        [property: JsonPropertyName("flags")]
        public Flags? Flags { get; set; }
        [property: JsonPropertyName("id")]
        public int Id { get; set; }
        [property: JsonPropertyName("safe")]
        public bool Safe { get; set; }
        [property: JsonPropertyName("lang")]
        public string? Lang { get; set; }
    }

    public class Flags
    {
        [property: JsonPropertyName("nsfw")]
        public bool Nsfw { get; set; }
        [property: JsonPropertyName("religious")]
        public bool Religious { get; set; }
        [property: JsonPropertyName("political")]
        public bool Political { get; set; }
        [property: JsonPropertyName("racist")]
        public bool Racist { get; set; }
        [property: JsonPropertyName("sexist")]
        public bool Sexist { get; set; }
        [property: JsonPropertyName("_explicit")]
        public bool Explicit { get; set; }
    }
}
