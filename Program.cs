string[] CreateArray(int N)
{
    string[] newArray = new string[N];
    for (int i = 0; i < N; i++)
    {
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

void ShowArray(string[] Array)
{
    Console.Write("[");

    if (Array.Length == 0)
        Console.Write("");

    else
        {
            for (int i = 0; i < Array.Length - 1; i++)
                Console.Write($"'{Array[i]}', ");
            Console.Write($"'{Array[Array.Length - 1]}'");
        }

    Console.Write("]");
    Console.WriteLine();
}

string[] ShortString(string[] Array)
{
    int M = 0;
    for (int i = 0; i < Array.Length; i++)
        if (Array[i].Length <= 3) M++;

    string[] newArray = new string[M];
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            newArray[j] = Array[i];
            j++;
        }
    }
    return newArray;
}

Console.WriteLine("Input size of array and it's elements:");
int N = Convert.ToInt32(Console.ReadLine());

string[] first = CreateArray(N);

ShowArray(first);

string[] second = ShortString(first);

ShowArray(second);