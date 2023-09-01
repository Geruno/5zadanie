Console.WriteLine("Введите размер массива: ");
string str_size = Console.ReadLine();
int size = int.Parse(str_size);
Console.WriteLine("Введите максимальное число в массиве: ");
string str_max = Console.ReadLine();
int max = int.Parse(str_max);
int[] FillArray (int size, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(max);
    }
    return array;
}
int Summ(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) summ += array[i];
    }
    return summ;
}
int[] array = FillArray(size, max);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Сумма чисел на нечетных позициях {Summ(array)}");