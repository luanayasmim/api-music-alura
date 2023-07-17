using ScreenSound_04.Filters;
using ScreenSound_04.Models;
using System.Text.Json;

using (HttpClient client = new())
{
	try
	{
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!; //! - indica que a variavel não pode ser nula

        LinqFilter.FilterAllGenres(musics);
        LinqOrder.ShowAllArtistOrder(musics);
        LinqFilter.FilterArtistByGenre(musics, "rock");
        LinqFilter.FilterMusicsByArtist(musics, "Twenty One Pilots");
        LinqFilter.FilterMusicsByKey(musics, "C#");

        var favoriteMusics = new FavoriteMusics("Luana");
        favoriteMusics.AddMusic(musics[654]);
        favoriteMusics.AddMusic(musics[1363]);
        favoriteMusics.AddMusic(musics[1585]);
        favoriteMusics.AddMusic(musics[365]);
        favoriteMusics.AddMusic(musics[1623]);
        favoriteMusics.AddMusic(musics[276]);
        favoriteMusics.AddMusic(musics[410]);
        favoriteMusics.AddMusic(musics[784]);
        favoriteMusics.AddMusic(musics[1243]);
        favoriteMusics.AddMusic(musics[1909]);
        favoriteMusics.ShowMusics();
        favoriteMusics.ExportMusicsJson();
    }
    catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
    }
}