using System;
using System.Linq;
using System.Web.Http;
using static Treehouse.FitnessFrog.Shared.Models.Entry;

namespace Treehouse.FitnessFrog.Spa.Controllers
{
    public class IntensitiesController : ApiController
    {
        public IntensitiesController()
        {
        }

        public IHttpActionResult Get()
        {
            return Ok(
                Enum.GetValues(typeof(IntensityLevel))
                .Cast<IntensityLevel>()
                .Select(s => new { id = (int)s, name = s.ToString()})
                .ToList()
                );
        }
    }
}