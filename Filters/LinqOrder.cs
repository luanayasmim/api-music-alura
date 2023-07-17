using ScreenSound_04.Models;

namespace ScreenSound_04.Filters;

internal class LinqOrder
{
    public static void ShowAllArtistOrder(List<Music> musics)
    {
        var artists = musics.OrderBy(m => m.Artist).Select(m=>m.Artist).Distinct().ToList();
        foreach(var artist in artists)
        {
            Console.WriteLine($"- {artist};");
        }
    }
}
