int[] NewArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

int[] simArray = NewArray(4, 0, 101);
Console.WriteLine($" array = [{String.Join(", ", simArray)}]");

int sum = 0;

for (int i = 0; i < simArray.Length; i+=2)
{
    sum += simArray[i];
}

Console.WriteLine($" -> {sum}");