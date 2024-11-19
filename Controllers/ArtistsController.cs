using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace minioppgave_restapi;

[ApiController]
[Route("api/artists")]

public class ArtistsController : ControllerBase
{
    private static List<Artists> artists = new List<Artists>{
        new Artists {Id = 1, Name = "Imagine Dragons", IsGroup = true, Members = "Dan Reynolds, Wayne Sermon, Ben McKee", YearFormed = 2008, Genres = "Pop rock, electropop, alternative rock", Labels = "Kidinaakorner, Interscope"},
        new Artists {Id = 2, Name = "Daft Punk", IsDuo = true, Members = "", YearFormed =, Genres = "", Labels = ""},
        new Artists {Id = 3, Name = "Taylor Swift", IsGroup = false, Genres = "", Labels = ""},
        new Artists {Id = 4, Name = "Keane", IsGroup = true, Members = "", YearFormed =, Genres = "", Labels = ""},
        new Artists {Id = 5, Name = "Susanne Sundfør", IsGroup = false, Genres = "", Labels = ""},
        new Artists {Id = 6, Name = "Fall Out Boy", Members = "", YearFormed =, Genres = "", Labels = ""},
        new Artists {Id = 7, Name = "Twice", Members = "", YearFormed =, Genres = "", Labels = ""},
        new Artists {Id = 8, Name = "Shakira", Members = "", Genres = "", Labels = ""},
        new Artists {Id = 9, Name = "Bigbang", Members = "G-Dragon, T.O.P, Daesung, Taeyang", Genres = "", Labels = ""},
        new Artists {Id = 10, Name = "", Members = "", YearFormed =, Genres = "", Labels = ""}
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
        if (artists == null)
        {
            return BadRequest("Client error occured!");
        }
        artists.Add(_artists);
        return CreatedAtAction(nameof(Post), new { id = _artists.Id, Title = _artists.Name, Members = _artists.Members, YearFormed = _artists.YearFormed, Genres = _artists.Genres, Labels = _artists.Labels }, artists);
    }
}