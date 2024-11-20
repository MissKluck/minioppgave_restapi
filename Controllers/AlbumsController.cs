using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/albums")]
public class AlbumsController : ControllerBase
{
    private static List<Albums> _Albums = new List<Albums> {
        new Albums {Id = 1, Title = "UNDERTALE Soundtrack", Artist = "Toby Fox", ReleaseYear = 2015, Genres = new List<string> {"Video game music", "chiptune"}},
        new Albums {Id = 2, Title = "Fine Line", Artist = "Harry Styles", ReleaseYear = 2019, Genres = new List<string> {"Pop rock", "indie pop"}},
        new Albums {Id = 3, Title = "Cause And Effect", Artist = "Keane", ReleaseYear =2019, Genres = new List<string> {"Alternative rock", "indie pop"}},
        new Albums {Id = 4, Title = "The Gods We Can Touch", Artist = "AURORA", ReleaseYear = 2022, Genres = new List<string> {"Electropop", "folk-pop", "ethereal", "art pop"}},
        new Albums {Id = 5, Title = "SOUR", Artist = "Olivia Rodrigo", ReleaseYear = 2021, Genres = new List<string> {"Pop", "alternative pop", "pop-punk"}},
        new Albums {Id = 6, Title = "Wild World", Artist = "Bastille", ReleaseYear = 2016, Genres = new List<string> {"Alternative rock", "pop rock", "synth pop"}},
        new Albums {Id = 7, Title = "The 2nd Law", Artist = "Muse", ReleaseYear = 2012, Genres = new List<string> {"Alternative rock", "art rock", "progressive rock", "electronic"}},
        new Albums {Id = 8, Title = "Inception: Music from the Motion Picture", Artist = "Hans Zimmer", ReleaseYear = 2010, Genres = new List<string> {"Film score"}},
        new Albums {Id = 9, Title = "Discovery", Artist = "Daft Punk", ReleaseYear = 2001, Genres = new List<string> {"French house", "disco", "nu-disco", "house"}},
        new Albums {Id = 10, Title = "MANIA", Artist = "Fall Out Boy", ReleaseYear = 2018, Genres = new List<string> {"Pop rock", "electronic rock", "electropop"}}
    };

    [HttpGet]
    public IEnumerable<Albums> Get()
    {
        return _Albums;
    }

    [HttpPost]
    public IActionResult Post([FromBody] Albums albums)
    {
        if (_Albums == null)
        {
            return BadRequest("Client side error occured!");
        }

        _Albums.Add(albums);
        return CreatedAtAction(nameof(Post), new { id = albums.Id, title = albums.Title, artist = albums.Artist, releaseyear = albums.ReleaseYear, genres = albums.Genres }, albums);
    }
}