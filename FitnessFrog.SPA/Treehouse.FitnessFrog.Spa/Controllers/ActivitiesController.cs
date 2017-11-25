using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Data;

namespace Treehouse.FitnessFrog.Spa.Controllers
{
    public class ActivitiesController : ApiController
    {
        private readonly ActivitiesRepository _activitiesRepository;

        public ActivitiesController(ActivitiesRepository activitiesRepository)
        {
            _activitiesRepository = activitiesRepository;
        }

        public IHttpActionResult Get()
        {
            return Ok(_activitiesRepository.GetList());
        }

        public IHttpActionResult Get(int id)
        {
            var activity = _activitiesRepository.Get(id);
            if (activity == null)
                return NotFound();

            return Ok(activity);
        }
    }
}