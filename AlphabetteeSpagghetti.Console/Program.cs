using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace AlphabetteeSpagghetti.AppConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var exitStrategy = false;
            do
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                var f = new Random().Next(1, 14);
                int b;
                do
                {
                    b = new Random().Next(1, 14);
                } while (b == f);

                Console.ForegroundColor = (ConsoleColor)f;
                Console.BackgroundColor = (ConsoleColor)b;

                Console.WriteLine("How longer string do you want?");
                var stringLength = Console.ReadLine();
                int length;
                int.TryParse(stringLength, out length);
                var result = AlphabetteeSpaghetti.Core.WordGenerator.GeneratePermutations(length);
                foreach (var r in result)
                {
                    Console.WriteLine(r);
                }
                stopwatch.Stop();
                Console.WriteLine($"{result.Count} results - Execution tool {stopwatch.Elapsed}");

                Console.WriteLine("Press any key to go again, or x to exit");
                if (Console.ReadKey(true).Key == ConsoleKey.X)
                {
                    exitStrategy = true;
                }
                Console.WriteLine("Going again in ");
                Console.Write("5, ");
                Thread.Sleep(1000);
                Console.Write("4, ");
                Thread.Sleep(1000);

                Console.Write("3, ");
                Thread.Sleep(1000);

                Console.Write("2, ");
                Thread.Sleep(1000);

                Console.Write("1, ");
                Console.Clear();
            } while (!exitStrategy);
        }
    }
}