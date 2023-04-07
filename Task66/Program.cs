// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummaElement(int A, int B)
{
    if (A == B) return B;
    return A+SummaElement(A + 1, B);
}

Console.Clear();
Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

if (first <= second)
{
    int summa = SummaElement(first, second);
    Console.WriteLine($"Сумма равна: {summa}");
}
else 
{
    int summa = SummaElement(second, first);
    Console.WriteLine($"Сумма равна: {summa}");
}

