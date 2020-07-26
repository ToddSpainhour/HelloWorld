using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Todd's C# Hello World...with a twist.");
            Console.WriteLine("");

            Console.WriteLine("First things first. What's your name?");
            var userName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine($"Well, hello there {userName}. Thanks for stopping by today.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine("");

            Console.WriteLine("Now lets pick a dialect in which to experience this console app.");
            Console.WriteLine("");
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

            Console.WriteLine("");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true); //  have to press button twice to advance;
            Console.WriteLine("");


            Console.WriteLine($"Great work, {userName}. Now what's your favorite color?");
            var usersFavoriteColor = Console.ReadLine();
            Console.WriteLine("");


            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Dog"};

            foreach (var animal in animals)
            {
                Console.WriteLine("");
                Console.WriteLine($"Have you ever seen a {usersFavoriteColor} {animal}, {userName}?");
                var numberOfVowels = animal.Count("aeiouAEIOU".Contains);
                var numberOfSyllables = numberOfVowels;

                    if (numberOfSyllables >= 2)
                    {
                        Console.WriteLine($"In case you were wondering, a {animal} has {numberOfSyllables} syllables.");
                        Console.WriteLine("");

                    }
            }
        }
    }
}
