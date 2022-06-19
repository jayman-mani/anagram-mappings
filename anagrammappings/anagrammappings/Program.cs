using System;
using System.Collections;

namespace anagrammappings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = new int[] { 12, 28, 46, 32, 50 };
            int[] anagram = new int[] { 50, 12, 32, 46, 28 };
            var solution = new Solution();
            var result = solution.anagrammapping(source, anagram);
            Console.WriteLine("******** Angagram Mapping Array *******");            
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
            Console.WriteLine("***************************************");
        }
    }

    class Solution
    {
        public int[] anagrammapping(int[] source, int[] dest)
        {
            int sourceLength = source.Length;
            int destLength = dest.Length;
            Hashtable table = new Hashtable();
            int[] result = new int[source.Length];
            for (int i = 0; i < destLength; i++)
            {
                table.Add(dest[i], i);
            }

            for (int i = 0; i < sourceLength; i++)
            {
                result[i] = (int)table[source[i]];
            }

            return result;
        }
    }
}
