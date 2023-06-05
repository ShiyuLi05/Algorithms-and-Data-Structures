using System;
using System.Collections.Generic;
using System.Text;

//Program 1: Appeared twice

int[] input1 = new int[] { 1, 2, 3, 4, 7, 9, 2, 4 };

Array.Sort(input1); //sort the input array to make sure if there are any number appeared twice, they must be related

for(int i = 0; i < input1.Length - 1; i++)
{
    if (input1[i] == input1[i + 1])
    {
        Console.Write(input1[i] + ", ");
    }
}
// O(n)
Console.WriteLine();



//Program 2: Merge arrays
Console.WriteLine();

int[] ints1 = new int[] { 1, 2, 3, 4, 5 };
int[] ints2 = new int[] { 2, 5, 7, 9, 13 };

/*
// The first method:
int output2Length = ints1.Length + ints2.Length;

int[] output2 = new int[output2Length];
int ints1Index = ints1.Length - 1;
int ints2Index = ints2.Length - 1;
int output2Index = ints1.Length + ints2.Length - 1;
bool sorted = false;

while (!sorted)
{
    if (ints1Index < 0 && ints2Index < 0)
    {
        sorted = true;
        continue;
    }else if (ints1Index < 0)
    {
        output2[output2Index--] = ints2[ints2Index--];
        continue;
    }else if (ints2Index < 0)
    {
        output2[output2Index--] = ints1[ints1Index--];
        continue;
    }

    if (ints1[ints1Index] < ints2[ints2Index])
    {
        output2[output2Index--] = ints2[ints2Index--];
    }
    else
    {
        output2[output2Index--] = ints1[ints1Index--];
    }
}

foreach (int number in output2)
{
    Console.Write($"{number}, ");
}

Console.WriteLine();
*/

//The second method:
List<int> mergedNum = new List<int>();
mergedNum.AddRange(ints1);
mergedNum.AddRange(ints2);
mergedNum.Sort((x, y) => x.CompareTo(y));   // use CompareTo method to sort the list; ascending order:x.CompareTo(y);Descending: -x.CompareTo(y)
foreach (int number in mergedNum)
{
    Console.Write($"{number}, ");
}
Console.WriteLine();

//Program 3: reverse the digits
int input3 = 3415;


// The first method:
char[] myNum = input3.ToString().ToCharArray();
StringBuilder output3 = new StringBuilder("", myNum.Length);
for (int i = 0; i < myNum.Length; i++)
{
    output3.Append(myNum[i]);
}
Console.WriteLine(output3);
//Running time: O(n)
   // But this way, I change the data type which is not really good


/*
//The second method:
int temp = input3;
int output3 = 0;
while (temp != 0)
{
    output3 = output3 * 10 + temp % 10;
    temp /= 10;
}
Console.WriteLine(output3);
//Running time: O(n)
*/