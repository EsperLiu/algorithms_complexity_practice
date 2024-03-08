
int[] numbers = { 4, 10, 12, 3, 6, 9, 7, 15 };
int resultV1 = MinDistance(numbers);
Console.WriteLine("Min. Distance is {0:d}", resultV1);

int resultV2 = MinDistanceV2(numbers);
Console.WriteLine("Min. Distance is {0:d}", resultV2);

int[] sortedNumbers = { 3, 4, 6, 7, 9, 10, 12, 15 };
int resultV3 = MinDistanceV3(sortedNumbers);
Console.WriteLine("Min. Distance is {0:d}", resultV3);



// First solution, using Q5's default algorithm
// Try every possible combination and compare dmin
static int MinDistance(int[] values)
{
    int count = 0;
    int dmin = 100000;
    for (int i = 0; i < values.Length; i++)
    {
        for (int j = 0; j <values.Length; j++)
        {
            count++;
            if (i!=j && Math.Abs(values[i] - values[j]) < dmin){
                dmin = Math.Abs(values[i] - values[j]);
            }
        }
    }
    Console.WriteLine("Operations count = {0:d} (version 1)", count);
    return dmin;
}


// Improved version
// Do not compare each element against itself;
// each combination only considered once
static int MinDistanceV2(int[] values)
{
    int dmin = 100000;
    int count = 0;
    for (int i = 0; i < values.Length -1 ; i++)
    {
        for (int j = i + 1; j < values.Length; j++)
        {
            count++;
            if (Math.Abs(values[i] - values[j]) < dmin)
            {
                dmin = Math.Abs(values[i] - values[j]);
            }
        }
    }
    Console.WriteLine("Operations count = {0:d} (version 2)", count);
    return dmin;
}

// Challenge: input Array is sorted
static int MinDistanceV3(int[] sortedValues)
{
    int dmin = 10000;
    int count = 0;
    for (int i = 0; i<sortedValues.Length - 1; i++)
    {
        count++;
        if (Math.Abs(sortedValues[i] - sortedValues[i+1]) < dmin)
        {
            dmin = Math.Abs(sortedValues[i] - sortedValues[i + 1]);
        }
    }
    Console.WriteLine("Operations count = {0:d} (version 3)", count);
    return dmin;
}