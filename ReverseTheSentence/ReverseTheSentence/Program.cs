using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTheSentence
{
    class Application
    {
        
        static void Main()
        {
            const string SumSentence = "Reversal is inevitable. Resistance is futile, human!";
            string sentence = Sentence(SumSentence);
            Console.WriteLine(sentence);
            Console.WriteLine(ReversedString(SumSentence));
        }
        
        public static string ReversedString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string Sentence(string sentence)
        {
            string[] words = sentence.Split();
            Array.Reverse(words);
            var result = string.Join(" ", words);
            return(result);
        }
    }
}
