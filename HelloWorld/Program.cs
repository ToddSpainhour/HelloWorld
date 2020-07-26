using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Todd's C# Hello World...with a twist.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            Console.WriteLine("First we must pick a dialect in which to experience this console app.");
            Console.WriteLine("Your options are: Southern, Northern, or Cajun");
            Console.WriteLine("Type in your answer and press Enter");

            var userSelectedDialect = Console.ReadLine();

            switch (userSelectedDialect.ToLower())
            {
                case "southern":
                    Console.WriteLine("Y'all know how many word sounds be in animal names? Mash one dem butons to find out.");
                    break;
                case "northern":
                    Console.WriteLine("You ever pondered how many of tha syllables the, uh animals have? Click a button on your keyboard to find out, eh?");
                    break;
                case "cajun":
                    Console.WriteLine("Day know da number of syllables in da animal name? Ya tink? Press da keyboard for more.");
                    break;
                default:
                    Console.WriteLine("Looks like you didn't pick a dialect, so we'll keep it generic. Click any key to see how many syllables some animal names have.");
                    break;
            }

            Console.ReadKey(true);

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Dog"};

            foreach (var animal in animals)
            {
                var numberOfVowels = animal.Count("aeiouAEIOU".Contains);
                var numberOfSyllables = numberOfVowels;

                    if (numberOfSyllables >= 2)
                    {
                        Console.WriteLine($"{animal} has {numberOfSyllables} syllables.");
                    }
            }
        }
    }
}
