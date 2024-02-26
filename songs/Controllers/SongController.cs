using Microsoft.AspNetCore.Mvc;
using WebApplication3.NewFolder;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController : ControllerBase
    {
       static private List<Song> songslist = new List<Song>();  
        [HttpGet]
            public ActionResult<IEnumerable<Song>> Get()
            {
            return Ok(songslist);
            }
            [HttpPost]
            public ActionResult Post([FromBody] Song song)
            {
            songslist.Add(song);
            return Ok("Hooray");

             }
        
    }
}
