using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    public class CountLetter
    {
        public Dictionary<char, int> FromStringToDictionary(string input)
        {
            Dictionary<char, int> output = new Dictionary<char, int>();

            char[] fromString = input.ToCharArray();

            foreach (var character in fromString)
            {
                if (!output.ContainsKey(character))
                {
                    output.Add(character, 1);
                }
                else
                {
                    output[character]++;
                }
            }

            return output;
        }
    }
}
