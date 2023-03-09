int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1000);
    }
    return array; 
}

int[] endArray = GetArray(4, 100, 1000);
Console.Write($"array = [{String.Join(", ", endArray)}]");

int res = 0;

for (int i = 0; i < endArray.Length; i++)
{
    if (endArray[i] % 2 == 0)
    {
        res++;
    }    
}

Console.Write($" -> {res}");