string[] Array(int N)
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
    for (int i = 0; i < Array.Length - 1; i++)
    {
        Console.Write($"'{Array[i]}', ");
    }
    int c = Array.Length - 1;
    Console.Write($"'{Array[c]}']");
    Console.WriteLine();
}

int []Size(string[] Array)
{
    int M = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        int b = Array[i].Length;
        if (b <= 3) M++;
    }
  
    string[] newArray = new string[M];
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        int b = Array[i].Length;
        if (b <= 3)
        {
            newArray[j] = Array[i];
            j++;
        }
    }
    return Array;
}


Console.WriteLine("Input size of array and it's elements:");
int N = Convert.ToInt32(Console.ReadLine());

string[] arr = Array(N);

ShowArray(arr);

string[] arr2 = Size(arr);

ShowArray(arr2);