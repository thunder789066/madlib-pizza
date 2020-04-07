using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madlib_Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an ajective : \t");
            string adjective1;
            adjective1 = Console.ReadLine();

            Console.Write("Enter a nationality : \t");
            string nationality;
            nationality = Console.ReadLine();

            Console.Write("Enter a person : \t");
            string person;
            person = Console.ReadLine();

            Console.Write("Enter a noun : \t");
            string noun1;
            noun1 = Console.ReadLine();

            Console.Write("Enter an adjective : \t");
            string adjective2;
            adjective2 = Console.ReadLine();

            Console.Write("Enter a noun : \t");
            string noun2;
            noun2 = Console.ReadLine();

            Console.Write("Enter an adjective : \t");
            string adjective3;
            adjective3 = Console.ReadLine();

            Console.Write("Enter an adjective : \t");
            string adjective4;
            adjective4 = Console.ReadLine();

            Console.Write("Enter a plural noun : \t");
            string pluralnoun;
            pluralnoun = Console.ReadLine();

            Console.Write("Enter a noun : \t");
            string noun3;
            noun3 = Console.ReadLine();

            Console.Write("Enter a number between 1-50 : \t");
            string number1;
            number1 = Console.ReadLine();

            Console.Write("Enter a shape ending with 's : \t");
            string shape;
            shape = Console.ReadLine();

            Console.Write("Enter a food : \t");
            string food1;
            food1 = Console.ReadLine();

            Console.Write("Enter a food : \t");
            string food2;
            food2 = Console.ReadLine();

            Console.Write("Enter a number between 1-1000 : \t");
            string number2;
            number2 = Console.ReadLine();

            Console.WriteLine("\n Pizza was invented by a " + adjective1 + " " + nationality);
            Console.WriteLine("\t chef named " + person + ". To make a pizza, you need");
            Console.WriteLine("to take a lump of " + noun1 + ", and make a thin, round");
            Console.WriteLine("\t" + adjective2 + " " + noun2 + ". Then you cover it with");
            Console.WriteLine(adjective3 + " sauce, " + adjective4 + " cheese, and fresh");
            Console.WriteLine("\t chopped " + pluralnoun + ". Next you have to bake it in a very");
            Console.WriteLine("hot " + noun3 + ". When it is done, cut it into " + number1);
            Console.WriteLine("\t" + shape + ". Some kids like " + food1 + " pizza the");
            Console.WriteLine("best, but my favorite is the " + food2 + " pizza. If I could, I");
            Console.WriteLine("\t would eat pizza " + number2 + " times a day!");

            Console.ReadKey();
        }
    }
}
