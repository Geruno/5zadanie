Console.WriteLine("Введите размер массива: ");
string str_size = Console.ReadLine();
int size = int.Parse(str_size);
int[] FillArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(100,1000);
    }
    return array;
}
int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 ==0) count++;
    }
    return count;
}
int[] array = FillArray(size);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Количество четных чисел {Count(array)}");