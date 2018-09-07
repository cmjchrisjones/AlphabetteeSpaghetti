using System;

namespace AlphabetteeSpagghetti.AppConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("How longer string do you want?");
            var stringLength = Console.ReadLine();
            int length;
            int.TryParse(stringLength, out length);
            var result = AlphabetteeSpaghetti.Core.WordGenerator.GeneratePermutations(length);
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine($"{result.Count} results");
            Console.ReadLine();
        }
    }
}