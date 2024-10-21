//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticalEvaluationDevanand.Task4
//{
//    public class TextProcessing
//    {
//        static string SummarizeText(string text, int maxLength = 20)
//        {
//            if (text.Length < maxLength)
//            {
//                return text;
//            }

//            var words = text.Split(' ');
//            var totalCharacters = 0;
//            var summaryWords = new List<string>();

//            foreach (var word in words)
//            {
//                summaryWords.Add(word);
//                totalCharacters += word.Length +1;
//                if (totalCharacters > maxLength)
//                    break;
//            }
//            return string.Join(" ", summaryWords) + "...";
//        }

//        static int CountWords(string text)
//        {
//            string[] words = text.Split(' ');
//            return words.Length;
//        }
//        static int CountSentences(string text)
//        {
//            string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
//            return sentences.Length;
//        }
//        static int CountCharacters(string text)
//        {
//            return text.Length;
//        }
//        static string FindLongestWord(string text)
//        {
//            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
//            string longestWord = string.Empty;
//            foreach (string word in words)
//            {
//                if (word.Length > longestWord.Length)
//                {
//                    longestWord = word;
//                }
//            }
//            return longestWord;
//        }
//        static string ReverseWords(string text)
//        {
//            StringBuilder reversedText = new StringBuilder();
//            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.None);
//            foreach (string word in words)
//            {
//                StringBuilder reversedWord = new StringBuilder();
//                for (int i = word.Length - 1; i >= 0; i--)
//                {
//                    reversedWord.Append(word[i]);
//                }
//                reversedText.Append(reversedWord + " ");
//            }
//            return reversedText.ToString().Trim();
//        }

//        static void Main(string[]  args) {
//            Console.WriteLine("Enter a paragraph of text:");
//            string paragraph = Console.ReadLine();
//            string summarizedText = SummarizeText(paragraph);
//            Console.WriteLine("Summarized text:");
//            Console.WriteLine(summarizedText);

//            int wordCount = CountWords(paragraph);
//            int sentenceCount = CountSentences(paragraph);
//            int characterCount = CountCharacters(paragraph);
//            Console.WriteLine("Number of words: " + wordCount);
//            Console.WriteLine("Number of sentences: " + sentenceCount);
//            Console.WriteLine("Number of characters: " + characterCount);
//            string longestWord = FindLongestWord(paragraph);
//            Console.WriteLine("Longest word: " + longestWord);
//            string reversedParagraph = ReverseWords(paragraph);
//            Console.WriteLine("Reversed paragraph: " + reversedParagraph);
//        }

//    }
//}
