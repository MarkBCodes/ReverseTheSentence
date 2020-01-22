using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTheSentence
{
    static class Words
    {
        public static string Sentence(string sentence)
        {
            string[] words = sentence.Split();
            Array.Reverse(words);
            var results = string.Join(" ", words);
            return(results);
        }
    }
    class Application
    {
        static void Main()
        {
            const string SumSentence = "I want to be reversed!";
            string sentence = Words.Sentence(SumSentence);
            Console.WriteLine(sentence);
        }
    }
}
