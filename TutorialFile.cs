using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class TutorialFile
    {
        static void Main(string[] args)
        {
            // write to the console
            Console.WriteLine("Hello World");

            // read from the console
            //Console.ReadLine();

            // strings
            string characterName = "John";

            // integers
            int characterAge = 35;

            // concatenation
            Console.WriteLine("There was once a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            // data types
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.2; // float is less accurate, decimal is more accurate
            bool isMale = true;

            // working with strings
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("Academy"));
            Console.WriteLine(phrase.Substring(8, 3));

            // working with numbers
            Console.WriteLine(5 * 8 + age);
            Console.WriteLine(gpa - 1.1);
            Console.WriteLine(Math.Pow(3, 2));

        }
    }
}
