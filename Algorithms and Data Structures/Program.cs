// Program 1. More than once:

string input1 = "Programmatic Python";
string string1 = input1.ToLower();
string repeatChars = "";
int charIndex = 0;
char[] output = new char[input1.Length]; // Still thinking about this array's length have no idea about how to defined this length opportune
for (int i = 0; i < string1.Length ; i++)
{
    char c = string1[i];
    for (int j = i + 1; j < string1.Length ; j++)
    {
       string searchString = string1.Substring(j, string1.Length - j);
        if (searchString.Contains(c) && Char.IsLetter(c) && !repeatChars.Contains(c)) // not inclue number and space; not repeat appeare a character had already been output
        {
            repeatChars += c;
            output[charIndex] = c;
            Console.Write($"'{output[charIndex]}'"); //how to output a char array like this ['a', 'b', 'c'] ???
            charIndex++;
            break;
        }
    }
}


