double[] YaAr(double size, double min, double max)
{
    double[] arr = new double[(int)size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().NextDouble();
    }
    
    return arr;
}

double[] oldAr = YaAr(4, -1, 0);
Console.WriteLine($"array = [{String.Join(", ", oldAr)}]");

double max = 0;
double min = 0;

for (int i = 0; i < oldAr.Length; i++)
{
    if (oldAr[i] >= max)
    {
        max = oldAr[i];
    }    
    else
    {
        min = oldAr[i];
    }
}

double res = (max - min);

Console.WriteLine($" max = {max}; min = {min} -> {res}");