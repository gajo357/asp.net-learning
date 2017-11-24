using IssueTrackerShared.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace IssueTracker.Controllers
{
    public class IssuesController : ApiController
    {
        public IEnumerable<Issue> Get()
        {
            return null;
        }

        public Issue Get(int id)
        {
            return null;
        }

        public void Post(Issue issue)
        {

        }

        public void Put(Issue issue)
        {

        }

        public void Delete(int id)
        {

        }
    }
}