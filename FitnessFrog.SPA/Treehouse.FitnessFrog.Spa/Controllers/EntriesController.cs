using System.Collections.Generic;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Data;
using Treehouse.FitnessFrog.Shared.Models;
using Treehouse.FitnessFrog.Spa.Dto;

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
        public IHttpActionResult Post(EntryDto entryDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var entry = entryDto.ToModel();
            _entriesRepository.Add(entry);

            entryDto.Id = entry.Id;

            return Created(
                Url.Link(WebApiConfig.DefaultApiName, new { controller = "Entries", id = entryDto.Id }),
                entryDto);
        }

        [HttpPut]
        public IHttpActionResult Put(int id, EntryDto entryDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
                
            _entriesRepository.Update(entryDto.ToModel());

            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _entriesRepository.Delete(id);
        }
    }

}