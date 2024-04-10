using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2LINQController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> queryString)
        {
            var query =
                from s in queryString
                where s.Length >= 5
                select s.ToUpper();

            return query.ToList();
        }
    }
}
