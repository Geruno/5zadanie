Console.WriteLine("Введите размер массива: ");
string str_size = Console.ReadLine();
int size = int.Parse(str_size);
Console.WriteLine("До какого числа генерация: ");
string str_max = Console.ReadLine();
int max = int.Parse(str_max);
Console.WriteLine("Сколько цифр после запятой: ");
string str_count = Console.ReadLine();
int count = int.Parse(str_count);
double[] FillArray (int size, int max, int count)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * max, count);
    }
    return array;
}
double Min(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
double Max(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double Razn(double[] array)
{
    double razn = Max(array) - Min(array);
    return razn;
}
double[] array = FillArray(size, max, count);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Разница между максимальным и минимальным {Razn(array)}");