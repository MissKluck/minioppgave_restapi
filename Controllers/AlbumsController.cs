using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/albums")]
public class AlbumsController : ControllerBase
{
    private static List<Albums> _Albums = new List<Albums> {
        new Albums {Id =, Title =, Artist =, ReleaseYear =, Genres =,}
    };

    [HttpGet]
    public IEnumerable<Albums> Get()
    {
        return _Albums;
    }

    [HttpPost]
    public IActionResult Post([FromBody] Albums albums)
    {
        if (albums == null)
        {
            return BadRequest("Client side error occured!");
        }

        _Albums.Add(albums);
        return CreatedAtAction(nameof(Post), new { id = albums.Id, title = albums.Title, artist = albums.Artist, releaseyear = albums.ReleaseYear, genres = albums.Genres }, albums);
    }
}