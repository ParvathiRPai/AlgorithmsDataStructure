using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Reverse  
    {
        public void reverseSentence(string input)
        {
            if(input==null)
            {
                throw new ArgumentNullException(" string is empty");
            }
            if(string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("string has null or white spaces");
            }
            var words = input.Split(' ');
            string outputString = string.Empty;
            foreach (var word in words)
            {
                outputString = outputString + ReverseString(word) + " ";
                
            }
            Console.WriteLine(outputString);

        }

        public string ReverseString(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string (charArray);
        }
    }
}
