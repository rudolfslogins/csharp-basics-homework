using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student(13.5);
            student.Display();

            student.Id = Guid.NewGuid();
            student.FirstName = "Aldis";
            student.LastName = "Miervaldis";
            student.Address = "Riga, Brivibas 34-23, LV-1001";

            student.Display();

            Person employee = new Employee("Manager");
            employee.Id = Guid.NewGuid();
            employee.FirstName = "Maris";
            employee.LastName = "Kalnins";
            employee.Address = "Valmiera, Riekstu 5";

            employee.Display();

            Console.ReadKey();
        }
    }
}
