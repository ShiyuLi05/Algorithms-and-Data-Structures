// Program 1: Max number:
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
        foreach(int number in list)
        {
            if (number > maxNumberInList)
            {
                maxNumberInList = number;
                MaxNumbers.Add(maxNumberInList);
            }        
        }
        maxNumberInList = 0;
    }
} else
{
    Console.WriteLine("Please not enter an empty list");
}

for (int i = 0; i < MaxNumbers.Count; i++)
{
    Console.WriteLine($"List {i + 1} has a maximum of {MaxNumbers[i]}.");
}
