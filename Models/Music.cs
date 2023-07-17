using System.Text.Json.Serialization;

namespace ScreenSound_04.Models;

internal class Music
{
    private string[] keys =
    {
        "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"
    };

    [JsonPropertyName("song")] //Anotação
    public string? Name { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string KeyExtension { 
        get 
        { 
            return keys[Key];
        } 
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Music: {Name}");
        Console.WriteLine($"Duration: {Duration/1000} s");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Key: {KeyExtension}");
    }
}
