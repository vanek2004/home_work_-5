// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Write("Введите размер массива --> ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size);
PrintArray(array);
int quant = NumberEvenNumbers(array);
Console.WriteLine();
Console.Write($"Количество четных чисел - {quant}");


int[] CreateArray(int length)                             //создаем массив
{
    int[] arr = new int[length];
    var random = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] arr)                                 //выводим массив
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int NumberEvenNumbers(int[] arr)                          //проверяем на четность
{
    int quantity = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) quantity += 1;
    }
    return quantity;
}