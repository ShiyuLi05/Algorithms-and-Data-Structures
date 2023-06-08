using System.Reflection.Metadata.Ecma335;

Stack<string> previousSongs = new Stack<string>();
Queue<string> nextSongs = new Queue<string>();
bool exit = false;
while (!exit)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Add a song to your playlist");
    Console.WriteLine("2. Play the next song in your playlist");
    Console.WriteLine("3. Skip the next song");
    Console.WriteLine("4. Rewind one song");
    Console.WriteLine("5. Exit");
    Console.Write("> ");
    string input = Console.ReadLine();
    if (input == "1")
    {
        Add(nextSongs);
    }
    else if (input == "2")
    {
        Next(nextSongs, previousSongs);
    }
    else if (input == "3")
    {
        Skip(nextSongs);
    }
    else if (input == "4")
    {
        Rewind(nextSongs, previousSongs);
    }
    else if (input == "5")
    {
        exit = true;
        break;
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.");
    }
}

static void Add(Queue<string> add)
{
    bool addSong = false;
    while (!addSong)
    {
        Console.Write("Enter Song Name: >");
        string songName = Console.ReadLine();
        if (!String.IsNullOrWhiteSpace(songName))
        {
            add.Enqueue(songName);
            Console.WriteLine($"\"{songName}\" added to your playlist.");
            addSong = true;
            break;
        }
        else
        {
            Console.WriteLine("Please enter a song name.");
            addSong = false;
        }
    }
}

static void Next(Queue<string> next, Stack<string> previousSongs)
{
    if (next.Count > 0)
    {
        string songName = next.Dequeue();
        previousSongs.Push(songName);
        Console.WriteLine($"Now playing \"{songName}\"");
        if (next.Count > 0)
        {
            Console.WriteLine($"Next song: {next.Peek()}");
        }
        else
        {
            Console.WriteLine("Next song: none queued");
        }
    }
    else
    {
        Console.WriteLine("No songs in the playlist.");
    }
}

static void Skip(Queue<string> nextSongs)
{
    if (nextSongs.Count > 0)
    {
        string skippedSong = nextSongs.Dequeue();
        Console.WriteLine($"Skipped song: \"{skippedSong}\"");
        if (nextSongs.Count > 0)
        {
            Console.WriteLine($"Next song: {nextSongs.Peek()}");
        }
        else
        {
            Console.WriteLine("Next song: none queued");
        }
    }
    else
    {
        Console.WriteLine("No songs in the playlist.");
    }
}

static void Rewind(Queue<string> nextSongs, Stack<string> previousSongs)
{
    if (previousSongs.Count > 0)
    {
        string previousSong = previousSongs.Pop();
        nextSongs.Enqueue(previousSong);
        Console.WriteLine($"Rewinding to song: \"{previousSong}\"");
    }
    else
    {
        Console.WriteLine("No previous songs in the playlist.");
    }
}