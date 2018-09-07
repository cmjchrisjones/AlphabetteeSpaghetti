using System.Collections.Generic;

namespace AlphabetteeSpaghetti.Core
{
    public static class Alphabet
    {
        public static List<char> GenerateFullAlphabet()
        {
            var alphabet = new List<char>();
            var i = 0;
            while (i < 26)
            {
                alphabet.Add(GetLetterOfAlphabetByPosition(i + 1));
                i++;
            }
            return alphabet;
        }

        public static char GetLetterOfAlphabetByPosition(int position)
        {
            bool isCaps = true;
            char c = (char)((isCaps ? 65 : 97) + (position - 1));
            return c;
        }
    }
}