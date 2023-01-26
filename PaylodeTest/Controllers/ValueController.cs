using System.Web.Http;
using PaylodeTest.Jwt.Filters;

namespace PaylodeTest.Jwt.Controllers
{
    public class ValueController : ApiController
    {
        [JwtAuthentication]
        public string Get()
        {
            return "value";
        }
    }
}
