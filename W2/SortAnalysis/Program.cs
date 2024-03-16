
// SortAnalysisV1(GenerateRandomArray(1000));


for (int i = 1000; i <= 20000; i = i + 1000)
{
    Console.WriteLine("Input size: " + i);
    for (int j = 0; j < 3; j++)
    {
        SortAnalysisV1(GenerateRandomArray(i));
    }
}


static int SortAnalysisV1(int[] A)
{
    // print out A to see the input
    // PrintArray(A);

    int count = 0;
    int n = A.Length;
    for (int i = 1; i <= n - 1; i++)
    {
        int v = A[i];
        int j = i - 1;

        while (j >= 0  && ++count > 0 && A[j] > v)
        {

            A[j + 1] = A[j];
            j = j - 1;
        }
        A[j + 1] = v;
    }
    // Print out A again to see what happened
    //PrintArray(A);
    Console.WriteLine("Comparison Count: " +  count);
    return count;
}

static void PrintArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.Write(A[i] + " ");
    }
    Console.WriteLine();
}

static int[] GenerateRandomArray(int size)
{
    int[] A = new int[size];

    int seed = (int) DateTime.UtcNow.Ticks;
    Random rnd = new Random(seed);

    for (int i = 0; i < A.Length; i++)
    {
        A[i] = rnd.Next(Int32.MaxValue); 
    }
    return A;
}