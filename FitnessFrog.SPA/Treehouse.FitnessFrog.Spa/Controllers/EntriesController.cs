using System.Collections.Generic;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Data;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Spa.Controllers
{
    public class EntriesController : ApiController
    {
        private readonly EntriesRepository _entriesRepository;

        public EntriesController(EntriesRepository entriesRepository)
        {
            _entriesRepository = entriesRepository;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_entriesRepository.GetList());
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var entry = _entriesRepository.Get(id);
            if (entry == null)
                return NotFound();

            return Ok(entry);
        }

        [HttpPost]
        public IHttpActionResult Post(Entry entry)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _entriesRepository.Add(entry);

            return Created(
                Url.Link("DefaultApi", new { controller = "Entries", id = entry.Id }),
                entry);
        }

        [HttpPut]
        public void Put(int id, Entry entry)
        {
            _entriesRepository.Update(entry);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _entriesRepository.Delete(id);
        }
    }

}