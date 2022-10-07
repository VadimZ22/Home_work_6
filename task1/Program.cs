/*Написать программу, которая рекурсивным методом переводит числа из десятичной системы счисления в двоичную
2 -> 10
11 -> 1011
16 -> 10000*/

Console.Clear();
Console.Write("Ведите число: ");
int n = int.Parse(Console.ReadLine()!);
List<int> number = new List<int>();
ToBinary(n);
ShowBinary(number);

void ToBinary(int i)
{
    i = Math.Abs(i);
    if (i / 2 == 0) 
    {
        //Console.Write(i % 2);
        number.Add(i % 2);
        return;
    }
    else 
    {
        //Console.Write(i % 2);
        number.Add(i % 2);
        ToBinary(i / 2);
    }
}

void ShowBinary(List<int> num)
{
    num.Reverse();
    for (int i = 0; i < num.Count; i++)
    {
        Console.Write(num[i]);
    }
}





