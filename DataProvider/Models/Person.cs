using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataProvider.Models
{
    public class Person
    {
        public int id;
        public string firstName;
        public string lastName;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}