using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Infrastructure;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetMovies()
        {
            var movies = new List<string> { "Movie 1", "Movie 2", "Movie 3" };
            return Ok(movies);
        }

        [HttpGet("premium")]
        [Authorize(Policy = "ForPremiumUsers")]
        public IActionResult GetPremiumMovies()
        {
            var movies = new List<string> { "Movie 1 premium", "Movie 2 premium", "Movie 3 premium" };
            return Ok(movies);
        }

        [HttpGet("readonly")]
        [Authorize(Permissions.Read)]
        public IActionResult GetReadonlyMovies()
        {
            var movies = new List<string> { "Movie 1 readonly", "Movie 2 readonly", "Movie 3 readonly" };
            return Ok(movies);
        }

        [HttpDelete("deleteOnly")]
        [Authorize(Permissions.Delete)]
        public IActionResult DeleteMovie()
        {
            return Ok();
        }
    }
}
