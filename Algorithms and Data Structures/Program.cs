using System.Diagnostics.Metrics;
using System;
using System.Runtime.InteropServices;

int n = 0;
while (n <= 0)
{   
    Console.WriteLine("Please enter interger value greater than 0");
    n = Int32.Parse(Console.ReadLine());
}

string[] words = new string[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter word {i + 1}");

    string newWords = Console.ReadLine();

    if (newWords.Length > 0)
    {
        words[i] = newWords;
    }
    else
    {
        Console.WriteLine("Sorry but you must enter at least one character");
        i--;
    }
}

Console.WriteLine("Please enter a character to count");

ConsoleKeyInfo keyInfo = Console.ReadKey();

char charToCount = keyInfo.KeyChar;

//get a count of how many times this character appears in all of words

int charCount = 0;
double wordsLength = 0;

foreach (string word in words)
{
    char[] chars = word.ToCharArray();
    wordsLength += chars.Length;

    foreach (char c in chars)
    {
        if (c == charToCount)
        {
            charCount++;
        }
    }
};


double per = charCount / wordsLength;

if(per >= 0.25)
{
    Console.WriteLine($"\nThe letter '{charToCount}' appears {charCount} times in the array.This letter makes up more than 25 % of the total number of characters.");
} else
{
    Console.WriteLine($"\nThe letter '{charToCount}' appears {charCount} times in the array.This letter makes up less than 25 % of the total number of characters.");
}
