using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome the Word Counter app.\nEnter your text : ");
        string input = Console.ReadLine();

        //Split the intput into words
        string[] words = input.Split(new char[] { ' ',',','!','?','.',':' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("\nTotal words : " + words.Length);

        // Create a dictionary to store word & letter frequencies
        Dictionary<string,int> wordFrequency = new Dictionary<string,int>();
        Dictionary<char, int> letterFrequency = new Dictionary<char, int>();
        int totalLetters = 0;

        // Count word frequencies
        foreach (string word in words)
        {
            if (wordFrequency.ContainsKey(word))
            {
                // If word exists, increment the count
                wordFrequency[word]++;
            }
            else
            {
                // If word does'nt exist, add it with the count 1
                wordFrequency.Add(word, 1);
            }

            foreach (char letter in word)
            {
                //count letters
                {
                    if (char.IsLetter(letter))
                    {
                        totalLetters++;

                        if (letterFrequency.ContainsKey(letter))
                        {
                            letterFrequency[letter]++;
                        }
                        else
                        {
                            letterFrequency.Add(letter, 1);
                        }
                    }
                }
            }
        }

        
        Console.WriteLine("\nWord Frequencies : ");
        foreach (var pair in wordFrequency)
        {
            Console.WriteLine($"- {pair.Key}: {pair.Value}");
        }

        Console.WriteLine($"\nTotal letters: {totalLetters}");
        Console.WriteLine("Letter Frequencies: ");
        foreach (var pair in letterFrequency)
        {
            Console.WriteLine($"- {pair.Key} : {pair.Value}");
        }
    } //Main
}