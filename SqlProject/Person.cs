using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlProject
{
    public class Person
    {
        //create a person that has an int as id, a first name, a last name, an adress and a city as strings
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }

        public Person(int id, string firstName, string lastName, string adress, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
            City = city;
        }
    }
}
