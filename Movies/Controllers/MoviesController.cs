using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Movies.Controllers
{
    [RoutePrefix("api/Movies")]
    public class MoviesController : BaseApiController
    {
        [HttpGet]
        [Route("")]
        public async Task<HttpResponseMessage> GetMovies()
        {
            var movies = await DbContext.Movies
                .OrderBy(m => m.Title)
                .ToListAsync();

            return OK(movies);
        }
    }
}