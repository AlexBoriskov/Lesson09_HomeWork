// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAkkerman (int A, int B)
{
    if (A==0) 
        return B+1;
    else 
        if ((A!=0) && (B==0)) 
            return FunctionAkkerman(A-1,1);
        else 
            return FunctionAkkerman(A-1, FunctionAkkerman(A,B-1));
}

Console.Clear();
Console.Write("Введите неотрицательное число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число: ");
int second = Convert.ToInt32(Console.ReadLine());

int result = FunctionAkkerman (first, second);
Console.WriteLine ($"Функция Аккермана = {result}");