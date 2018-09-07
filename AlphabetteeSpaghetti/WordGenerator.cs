using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AlphabetteeSpaghetti.Core
{
    public static class WordGenerator
    {
        private static readonly List<char> _alphabet = Alphabet.GenerateFullAlphabet();

        public static List<string> GeneratePermutations(int length)
        {
            var list = GenerateCharacter();

            if (length == 1)
            {
                return list;
            }
            else
            {
                var list2 = new List<string>();

                var a = 0;
                foreach (var w in list)
                {
                    var p = Next(length, list, list2, a, w).ToString();
                    list2.Add(p);
                }
                return list2;
            }
        }

        private static int Next(int length, List<string> list, List<string> list2, int a, string w)
        {
            var max = 0;
            list.ForEach(a =>
            {
                if (a.Length > max)
                {
                    max = a.Length;
                }
            });
            
            do
            {
                var x = 0;
                while (x < 26)
                {
                    list2.Add(Next(length, list, list2, a, w).ToString());
                    x++;
                }
                a++;
            }
            while (a < length);

            return a;
        }

        private static List<string> GenerateCharacter()
        {
            var list = new List<string>();

            foreach (var c in _alphabet)
            {
                list.Add(c.ToString());
            }

            return list;
        }

        private static char GenerateNextChar(int index)
        {
            return _alphabet[index];
        }
    }
}