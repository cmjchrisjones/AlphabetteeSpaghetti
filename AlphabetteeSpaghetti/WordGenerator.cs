using System.Collections.Generic;

namespace AlphabetteeSpaghetti.Core
{
    public class WordGenerator
    {
        private static readonly List<char> _alphabet = Alphabet.GenerateFullAlphabet();

        public static List<string> GeneratePermutations(int length)
        {
            var values = new List<string>();

            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                values.Add(ch.ToString());
            }

            for (int i = 1; i < length; i++)
            {
                // Make combinations containing i + 1 letters.
                var new_values = new List<string>();
                foreach (string str in values)
                {
                    // Add all possible letters to this string.
                    foreach (char ch in _alphabet)
                    {
                        new_values.Add(str + ch);
                    }
                }

                // Replace the old values with the new ones.
                values = new_values;
            }
            return values;
        }
    }
}