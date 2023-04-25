using System.Text.Json.Serialization;

namespace Prac1
{
    public record class Repository([property: JsonPropertyName("name")] string Name);
}
