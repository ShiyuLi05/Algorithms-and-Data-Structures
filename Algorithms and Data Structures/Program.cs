using System;
using System.Diagnostics;


static int getHighestValueInList(int number, int HighestValue)
{
    if (number > HighestValue)
    {
        HighestValue = number;
    }
    return HighestValue;
}


// Program 1: Max number:
//On^2

List<List<int>> numbers = new List<List<int>>
{
    new List<int> { 1, 5, 3 },
    new List<int> { 9, 7, 3, -2 },
    new List<int> { 2, 1, 2 }
};
List<int> MaxNumbers = new List<int>();
int maxNumberInList = numbers[0][0];
if (numbers.Count > 0) 
{
    foreach(List<int> list in numbers) 
    {
        maxNumberInList = list[0];
        foreach (int number in list)
        {
            maxNumberInList = getHighestValueInList (number, maxNumberInList);
            /*if (number > maxNumberInList)
            {
                maxNumberInList = number;
            }*/
        }
        MaxNumbers.Add(maxNumberInList);
    }
} else
{
    Console.WriteLine("Please not enter an empty list");
}

for (int i = 0; i < MaxNumbers.Count; i++)
{
    Console.Write($" List {i + 1} has a maximum of {MaxNumbers[i]}. ");
}
Console.WriteLine();



//Program 2:  HighestGrade:
// On^2

List<List<int>> grades = new List<List<int>>
{
    new List<int> { 85, 92, 67, 94, 94 },
    new List<int> { 50, 60, 57, 95 },
    new List<int> { 95, 101 }
};
int maxGrade = 100; int minGrade = 0;
int highestGrade = grades[0][0];
int gradeIndex = 0;
string output2 = "";
if (grades.Count > 0)
{
    foreach (List<int> list in grades)
    {
        gradeIndex++;
        foreach (int grade in list)
        {
            if (minGrade <= grade && grade <= maxGrade)
            {
                highestGrade = getHighestValueInList(grade, highestGrade);
                /*if (grade >= highestGrade)
                {
                    highestGrade = grade;
                }*/
                output2 = $"The highest grade is {highestGrade}. This grade was found in class {gradeIndex}.";
            } else
            {
                output2 = "Incorrect grade. All grades must between 0 - 100";
            }
        }
    }
}
else
{
    output2 = "Please not enter an empty list";
}

Console.WriteLine(output2);
Console.WriteLine();



//Program 3: OrderByLooping:
//On^2

List<int> OrderByLooping = new List<int> { 6, -2, 5, 3 };
/*
bool sorted = false;

if (OrderByLooping.Count > 0)
{
    while (!sorted)
    {
        sorted = true;
        for (int i = 0; i < OrderByLooping.Count - 1; i++)
        {
            if (OrderByLooping[i] > OrderByLooping[i + 1])
            {
                sorted = false;
                int stored = OrderByLooping[i]; 
                OrderByLooping[i] = OrderByLooping[i + 1];
                OrderByLooping[i + 1] = stored;
            }
        }
    }
}
Console.WriteLine(String.Join(", ",OrderByLooping));
*/


//Bubble sort:
int temp = 0;
for (int i = 0; i < OrderByLooping.Count - 1; i++)  
{
    for (int j = 0; j < OrderByLooping.Count - 1 - i; j++)  
    {
        if (OrderByLooping[j] > OrderByLooping[j + 1])
        {   
            temp = OrderByLooping[j];
            OrderByLooping[j] = OrderByLooping[j + 1];
            OrderByLooping[j + 1] = temp;
        }
    }
}
Console.WriteLine(String.Join(", ",OrderByLooping));



