using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classes = { "English III", "Precalculus", "Music Theory", "Biotechnology", "Principles of Technology I", "Latin II", "AP US History", "Business Computer Infomation Systems" };
            string[] teachers = { "Ms. Lapan", "Mrs. Gideon", "Mr. Davis", "Ms. Palmer", "Ms. Garcia", "Mrs. Barnett", "Ms. Johannessen", "Mr. James" };
            int[] lineNer = {1, 2, 3, 4, 5, 6, 7, 8 };
            int classesLength = GetLength(classes);
            int teachersLength = GetLength(teachers);

            Console.WriteLine("+" + new String('-', 54) + "+");
            for (int i = 0; i < classes.Length; i++)
                Console.WriteLine("|" + lineNer[i] + "|" + new String('\0', classesLength - classes[i].Length) + classes[i] + "|" + new String('\0', teachersLength - teachers[i].Length) + teachers[i] + "|");
            Console.WriteLine("+" + new String('-', 54) + "+");
            Console.WriteLine("\n ------------ Press (\u03a0) to quit! ------------");
            Console.ReadKey();
        }
        static int GetLength(string[] arr)
        {
            int result = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                
                if (result < arr[i].Length)
                {
                    result = arr[i].Length;
                }
            }
            return result;
        }
    }
}
