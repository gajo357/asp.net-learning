﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        public IEnumerable<Entry> Get()
        {
            return _entriesRepository.GetList();
        }

        [HttpGet]
        public Entry Get(int id)
        {
            return _entriesRepository.Get(id);
        }

        [HttpPost]
        public void Post(Entry entry)
        {
            _entriesRepository.Add(entry);             
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