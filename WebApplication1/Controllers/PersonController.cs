using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataProvider.Models;

namespace WebApplication1.Controllers
{
    public class PersonController : ApiController
    {
        [HttpGet]
        public int Get()
        {
            return 1;
        }

        [HttpGet]
        public List<Person> GetPersons()
        {
            WebDatabaseContext webDatabaseContext = new WebDatabaseContext();
            List<Person> persons = webDatabaseContext.Persons.Select(s => s).ToList();
            foreach (Person person in persons) 
                persons.Add(person);
            return persons;
        }
    }
}
