using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class AnagramClass
    {
        public bool AreTheseTwoStringsAnagram(string input1, string input2)
        {
            bool isAnagram = false;
            char[] input1CharArray = input1.ToCharArray();
            char[] input2CharArray = input2.ToCharArray();

            Array.Sort(input1CharArray);
            Array.Sort(input2CharArray);

            if (input1CharArray.Length == input2CharArray.Length && input2CharArray.SequenceEqual(input1CharArray))
            {
                    isAnagram = true;
                    return isAnagram;
            }

            return isAnagram;
        }
    }
}
