using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Search for a word within the sentence: " + sentence);

            string input = Console.ReadLine();

            if (sentence.ToUpper().Contains(input.ToUpper()) == true) 
            {

                Console.WriteLine(input + " was found in the sentence!");
                Console.WriteLine("Index: " + sentence.IndexOf(input));
                Console.WriteLine("Length: " + input.Length);

                Console.WriteLine(sentence.Remove(sentence.IndexOf(input), input.Length));
            }
            else
            {

                Console.WriteLine(input + " was not found in the sentence");
            }


        }
    }
}
