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
            const string SumSentence = "Reversal if inevitable. Resistance is futile, human!";
            string sentence = Words.Sentence(SumSentence);
            Console.WriteLine(sentence);
            Console.WriteLine(StringReverse.ReversedString(SumSentence));
        }
    }

    static class StringReverse
    {
       public static string ReversedString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
    static class Words
    {
        public static string Sentence(string sentence)
        {
            string[] words = sentence.Split();
            Array.Reverse(words);
            var result = string.Join(" ", words);
            return(result);
        }

    }

}
