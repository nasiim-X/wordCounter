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

        // Create a dictionary to store word frequencies
        Dictionary<string,int> wordFrequency = new Dictionary<string,int>();

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
        }

        Console.WriteLine("\nWord Frequencies : ");
        foreach (var pair in wordFrequency)
        {
            Console.WriteLine($"- {pair.Key}: {pair.Value}");
        }
    } //Main
}