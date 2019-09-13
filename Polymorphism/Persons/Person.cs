using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public abstract class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public abstract void Display();
        protected Person()
        {
        }

        public Person(Guid id, string firstName, string lastName, string address)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }

/*        public abstract void Display()
        {
            Console.WriteLine($"ID: {this.Id}; First Name: {this.FirstName}; Last Name: {this.LastName}; Address: {this.Address}");
        }*/
    }
}
