// Program 1: Max number:
//On^2
List<List<int>> numbers = new List<List<int>>
{
    new List<int> { 1, 5, 3 },
    new List<int> { 9, 7, 3, -2 },
    new List<int> { 2, 1, 2 },
    new List<int> { -1 }
};
List<int> MaxNumbers = new List<int>();
int maxNumberInList = numbers[0][0];
if (numbers.Count > 0) 
{
    foreach(List<int> list in numbers) 
    {
        maxNumberInList = list[0]; // if there's any negative number, it also can be output
        foreach (int number in list)
        {
            if (number > maxNumberInList)
            {
                maxNumberInList = number;
                
                
            }       
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

List<List<int>> grades = new List<List<int>>();
List<int> Grades1 = new List<int> { 85, 92, 67, 94, 94 };