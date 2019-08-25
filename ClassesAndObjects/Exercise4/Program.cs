using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie[] filmArr =
            {
                new Movie("Casino Royale", "Eon Productions","PG-­13"),
                new Movie("Glass", "Buena Vista International","PG-­13"),
                new Movie("Spider-Man: Into the Spider-Vers", "Columbia Pictures"),
                new Movie("The Ring", "DreamWorks Pictures", "PG"),
                new Movie("Zombieland", "Columbia Pictures", "PG-6")
            };
/*            foreach (var item in filmArr)
            {
                Console.WriteLine(filmArr[item].ToString());
            }*/
            for (var i = 0; i < filmArr.Length; i++)
            {
                Console.WriteLine(filmArr[i].ToString());
            }

            Movie[] pgArr = GetPg(filmArr);
            Console.WriteLine("\nFilms with 'PG' rating: ");
            for (var i = 0; i < pgArr.Length; i++)
            {
                if (pgArr[i] != null)
                {
                    Console.WriteLine(pgArr[i].ToString());
                }
                
            }
            Console.ReadKey();
        }
        public static Movie[] GetPg(Movie[] mov)
        {
            Movie[] pgMov = new Movie[mov.Length];

            var pgMovIndex = 0;
            for (var i = 0; i < mov.Length; i++)
            {
                if (mov[i].Rating.Equals("PG"))
                {
                    pgMov[pgMovIndex] = mov[i];
                    pgMovIndex++;
                }
            }

            return pgMov;
        }
    }
}
