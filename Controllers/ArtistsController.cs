using Microsoft.AspNetCore.Mvc;

namespace minioppgave_restapi;
[ApiController]
[Route("api/artists")]

public class ArtistsController : ControllerBase
{
    private static List<Artists> artists = new List<Artists>{
        new Artists {Id = 1, Name = "Imagine Dragons", IsGroup = true, Members = "Dan Reynolds, Wayne Sermon, Ben McKee", YearStarted = 2008, Genres = new List<string> {"Pop rock, electropop, alternative rock"}},
        new Artists {Id = 2, Name = "Daft Punk", IsGroup = true, Members = "Thomas Bangalter & Guy-Manuel de Homem-Christo", YearStarted = 1993, Genres = new List<string> {"French house, electronic, dance, disco"}},
        new Artists {Id = 3, Name = "Taylor Swift", IsGroup = false, YearStarted = 2003, Genres = new List<string> {"Country, pop, folk, rock"}},
        new Artists {Id = 4, Name = "Keane", IsGroup = true, Members = "Tom Chaplin, Tim Rice-Oxley, Richard Hughes, Jesse Quin", YearStarted = 1995, Genres = new List<string> {"alternate rock, indie, post-Britpop"}},
        new Artists {Id = 5, Name = "Susanne Sundfør", IsGroup = false, YearStarted = 2005, Genres = new List<string> {"Art pop, electronica, folk, experimental pop"}},
        new Artists {Id = 6, Name = "Fall Out Boy", IsGroup = true, Members = "Patrick Stump, Pete Wentz, Joe Trohman, Andy Hurley", YearStarted = 2001, Genres = new List<string> {"Pop-punk, pop rock, emo, alternative rock"}},
        new Artists {Id = 7, Name = "Twice", IsGroup = true, Members = "Nayeon, Jeongyeon, Momo, Sana, Jihyo, Mina, Dahyun, Chaeyoung, Tzuyu", YearStarted = 2015, Genres = new List<string> {"K-pop, J-pop, bubblegum pop, EDM"}},
        new Artists {Id = 8, Name = "Shakira", IsGroup = false, YearStarted = 1990, Genres = new List<string> {"Latin pop, pop, dance, reggaeton"}},
        new Artists {Id = 9, Name = "BigBang", IsGroup = true, Members = "G-Dragon, Daesung, Taeyang", YearStarted = 2006, Genres = new List<string> {"K-pop, J-pop, hip hop, dance, electronic"}},
        new Artists {Id = 10, Name = "MARINA", IsGroup = false, YearStarted = 2005, Genres = new List<string> {"Electropop, synth-pop, indie pop, art pop"}}
    };

    // create the GET endpoint
    [HttpGet]
    public IEnumerable<Artists> Get()
    {
        return artists;
    }
    // create the POST endpoint
    [HttpPost]
    public IActionResult Post([FromBody] Artists _artists)
    {
        if (_artists == null)
        {
            return BadRequest("Client error occured!");
        }
        artists.Add(_artists);
        return CreatedAtAction(nameof(Post), new { id = _artists.Id, Title = _artists.Name, Members = _artists.Members, YearStarted = _artists.YearStarted, Genres = _artists.Genres }, artists);
    }
}