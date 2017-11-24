using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Spa.Controllers
{
    public class EntriesController : ApiController
    {
        [HttpGet]
        public IEnumerable<Entry> Get()
        {
            var acitvityBiking = new Activity { Name = "Biking" };
            return new List<Entry>
            {
                new Entry(2017, 1, 2, acitvityBiking, 10.0m),
                new Entry(2017, 1, 3, acitvityBiking, 12.2m)
            };
        }

        [HttpGet]
        public Entry Get(int id)
        {
            return null;
        }

        [HttpPost]
        public void Post(Entry entry)
        {
             
        }

        [HttpPut]
        public void Put(int id, Entry entry)
        {

        }

        [HttpDelete]
        public void Delete(int id)
        {

        }
    }

}