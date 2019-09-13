using System;

namespace Persons
{
    public class Student : Person
    {
        public double _gpa { get; set; }

        public Student(double gpa)
        {
            this._gpa = gpa;
        }
        public override void Display()
        {
            Console.WriteLine($"ID: {Id}; First Name: {FirstName}; Last Name: {LastName}; Address: {Address}; GPA: {this._gpa}");
        }
    }
}