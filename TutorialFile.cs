namespace Tutorial
{
    class TutorialFile
    {
        static void Main(string[] args)
        {
            // write to the console
            Console.WriteLine("Hello World");

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
            Console.WriteLine(phrase[0] + grade + Convert.ToString(isMale));
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("Academy"));
            Console.WriteLine(phrase.Substring(8, 3));

            // working with numbers
            Console.WriteLine(5 * 8 + age);
            Console.WriteLine(gpa - 1.1);
            Console.WriteLine(Math.Pow(3, 2));

            // get user input
            /*
            Console.Write("Enter your name: "); // no new line
            string? name = Console.ReadLine(); // possibly null value
            Console.WriteLine("Hello " + name);
            */

            // convert strings to numbers
            int num1 = Convert.ToInt32("45"); // or double...ToDouble
            Console.WriteLine(num1 + age);

            // arrays
            int[] luckyNumbers = { 4, 8, 15, 23, 42 };
            luckyNumbers[1] = 20;
            Console.WriteLine(luckyNumbers[1]);
            string[] friends = new string[10]; // size 10 array
            friends[0] = "Jim";

            // calling methods
            SayHi(friends[0]);
            Console.WriteLine(Cube(5));

            // if statements
            bool isTall = true;

            if (isMale && isTall) // || for 'or'
            {
                Console.WriteLine("You are a tall male");
            }

            else if (isMale && !isTall)
            {
                Console.WriteLine("You are not a tall male");
            }

            else if (!isMale && isTall)
            {
                Console.WriteLine("You are tall but not a male");
            }

            else
            {
                Console.WriteLine("You are not male and not tall");
            }

            Console.WriteLine(GetMax(2, 10));

        }

        // methods
        static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        // the return statement
        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        static int GetMax(int num1, int num2)
        {
            int result;

           if (num1 >= num2)
                    result = num1;
           else
                    result = num2;

            return result;
        }

    }
}
