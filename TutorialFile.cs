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
        }
    }
}
