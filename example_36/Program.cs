// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива --> ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size);
PrintArray(array);
int quant = SumNumbersInOddPositions(array);
Console.WriteLine();
Console.Write($"Сумма элементов, стоящих на нечетных позициях - {quant}");


int[] CreateArray(int length)                             //создаем массив
{
    int[] arr = new int[length];
    var random = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(10, 100);
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

int SumNumbersInOddPositions(int[] arr)                          //проверяем на четность i и если оно нечетное, то складываем
{
    int quantity = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) quantity += arr[i];
    }
    return quantity;
}