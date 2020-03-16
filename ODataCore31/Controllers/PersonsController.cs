using System.Collections.Generic;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace ODataCore31.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly PersonContext _personContext;

        public PersonsController(PersonContext personContext)
        {
            _personContext = personContext;
        }

        [EnableQuery()]
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _personContext.People;
        }
    }
}
