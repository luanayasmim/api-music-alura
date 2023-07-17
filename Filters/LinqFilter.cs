using ScreenSound_04.Models;

namespace ScreenSound_04.Filters;

internal class LinqFilter
{
    public static void FilterAllGenres(List<Music> musics)
    {
        var genres = musics.Select(g => g.Genre).Distinct().ToList();

        foreach (var genre in genres)
        {
            Console.WriteLine($"- {genre};");
        }
    }

    public static void FilterArtistByGenre(List<Music> musics, string genre)
    {
        var artistsByGenre =  musics.Where(m => m.Genre!.Contains(genre)).Select(m=>m.Artist).Distinct().ToList();
        Console.WriteLine($"Showing artists by genre: {genre}");
        foreach (var artist in artistsByGenre)
        {
            Console.WriteLine($"- {artist};");
        }
    }

    public static void FilterMusicsByArtist(List<Music> musics, string artist)
    {
        var musicsByArtist = musics.Where(m => m.Artist!.Equals(artist)).ToList();
        Console.WriteLine($"{artist}:");
        foreach (var music in musicsByArtist)
        {
            Console.WriteLine($" - {music.Name};");
        }
    }

    public static void FilterMusicsByKey(List<Music> musics, string key)
    {
        var musicsByKey = musics.Where(m=>m.KeyExtension!.Equals(key)).ToList();
        Console.WriteLine($"Musics in {key}");
        foreach(var music in musicsByKey)
        {
            Console.WriteLine($"- {music.Name};");
        }
    }
}
