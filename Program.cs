// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
Console.Write("Введите длинну массива = ");
int length = Convert.ToInt32(Console.ReadLine());
int[] CreateRandomArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
    return array;
}
int SummOddPosNumber(int[] array)
{
    int summ = 0;
    for (int i = 1; i < length; i= i + 2)
    {
        summ = summ + array[i];
    }
    return summ;
}

void PrintArray(int[] array)
{
    Console.Write("В представленном массиве - [");
    for (int i = 0; i < length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}
int[] array = CreateRandomArray(length);
int summOddPosNumber = SummOddPosNumber(array);
PrintArray(array);
Console.WriteLine($" Сумма элементов на нечетных позициях = {summOddPosNumber}");
