using System.Text.Json;

namespace ScreenSound_04.Models;

internal class FavoriteMusics
{
    public string? Owner { get; set; }
    public List<Music> Musics { get; set; }
    public FavoriteMusics(string owner)
    {
        Owner = owner;
        Musics = new List<Music>();
    }
    public void AddMusic(Music music)
    {
        Musics.Add(music);
    }
    public void ShowMusics()
    {
        Console.WriteLine($"List favorite musics from {Owner}");
        foreach (Music music in Musics)
        {
            Console.WriteLine($"- {music.Name};");
        }
    }

    public void ExportMusicsJson()
    {
        string json = JsonSerializer.Serialize(
            new
            {
                name = Owner,
                musics = Musics
            }
        );

        string filename = $"favorite-musics-{Owner}.json";
        File.WriteAllText( filename, json );
        Console.WriteLine($"File json created :)\n {Path.GetFullPath(filename)}");
    }
}
