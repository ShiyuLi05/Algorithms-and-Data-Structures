// Program 1. More than once:
using System.Text;

Console.WriteLine("Program 1: ");

string input1 = "Programmatic Python";
string string1 = input1.ToLower();
string repeatChars = "";
int charIndex = 0;
char[] output1 = new char[input1.Length]; // Still thinking about this array's length have no idea about how to defined this length opportune
string feedBack = "The repeated characters are ";
if(string1.Length > 0)
{
    for (int i = 0; i < string1.Length ; i++)
    {
        char c = string1[i];
        for (int j = i + 1; j < string1.Length ; j++)
        {
           string searchString = string1.Substring(j, string1.Length - j);
            if (searchString.Contains(c) && Char.IsLetter(c) && !repeatChars.Contains(c)) // not inclue number and space; not repeat appeare a character had already been output
            {
                repeatChars += c;
                output1[charIndex] = c;
                feedBack += $"'{output1[charIndex]}'";
                charIndex++;
                break;
            }
            if (repeatChars == "") { feedBack = "No repeated characters. "; }
        }
    }
} else { feedBack = "Please enter a string."; };

Console.WriteLine(feedBack);



// Program 2. Unique words:
Console.WriteLine();
Console.WriteLine("Program 2: ");

string input2 = "To be or not to be";
string[] words = input2.ToLower().Split(' ');

if (input2.Length <= 0 || String.IsNullOrWhiteSpace(input2))
{
    throw new Exception("Please enter something");
}

int uniqueIndex = 0;
string[] uniqueWords = new string[words.Length];
string tempWord = "";

for (int i = 0; i < words.Length; i++)
{
    tempWord = words[i];
    if (!uniqueWords.Contains(tempWord))
    {
        uniqueIndex++;
        uniqueWords[uniqueIndex] = tempWord;
    }
}
Console.Write("The unique words are ");

foreach (string word in uniqueWords)
{
    if (!String.IsNullOrEmpty(word))  //remove the empty space
    {
        Console.Write($"'{word}' ");
    }
}
Console.WriteLine();



// Program 3. Reverse string:
Console.WriteLine();
Console.WriteLine("Program 3: ");

string input3 = "abcdefg";
StringBuilder reversedString = new StringBuilder();
char[] chars = input3.ToCharArray();
for (int i = chars.Length - 1; i > -1; i--)
{
    reversedString.Append(chars[i]);
}

string output3 = reversedString.ToString();

Console.WriteLine(output3);


//Program 4. longest word:
Console.WriteLine();
Console.WriteLine("Program 4: ");

string input4 = "Tiptoe through the tulips";
string[] string4 = input4.ToLower().Split(' ');
string output4 = "";
int len = 0;

if (input4.Length <= 0 || String.IsNullOrWhiteSpace(input4))
{
    throw new Exception("Please enter something");
}

for(int i  = 0; i < string4.Length - 1; i++)
{
    len = string4[i].Length;
    if (len <= string4[i + 1].Length && output4.Length <= string4[i + 1].Length)
    {
        output4 = string4[i + 1];
    }
}

Console.WriteLine(output4);



