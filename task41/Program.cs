/*Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
5
0
7
8
-2
-2 -> 2

5
1
-7
567
89
223-> 3*/


Console.Clear();
Console.Write("Ведите количество чисел: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = new int[number];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Пользователь ввел {CountPositive(array)} чисел больше 0.");

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        arr[i] = int.Parse(Console.ReadLine()!);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int CountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;
}

