using System;

namespace Persons
{
    public class Employee : Person
    {
        private string _jobTitle { get; set; }

        public Employee(string jobTitle)
        {
            this._jobTitle = jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"ID: {Id}; First Name: {FirstName}; Last Name: {LastName}; Address: {Address}; GPA: {this._jobTitle}");
        }
    }
}