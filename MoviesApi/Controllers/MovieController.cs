using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetMovies()
        {
            var movies = new List<string> { "Movie 1", "Movie 2", "Movie 3" };
            return Ok(movies);
        }

    }
}
