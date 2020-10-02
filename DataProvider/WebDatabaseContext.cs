using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DataProvider.Models;

namespace WebApplication1
{
    public class WebDatabaseContext : DbContext
    {
        public WebDatabaseContext() : base("WebDatabaseContext")
        {

        }

        public virtual DbSet<Person> Persons { get; set; }
    }
}