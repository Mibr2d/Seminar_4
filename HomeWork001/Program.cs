// Задача 1: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную 
// степень B. Реализовать через функции.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Promt(string message)
{
    System.Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int number1 = Promt("Введите число A");
int number2 = Promt("Введите число B");

// double result=Math.Pow(number1,number2);
// Console.WriteLine($"Результат {result},число  {number1}, в степени {number2}");
int Prod(int number1)
{
    int Prod = 1;
    for (int i = 0; i < number2; i++)
    {
        Prod *= number1;
    }
    return Prod;
}
int result = Prod(number1);
System.Console.WriteLine($"{result}");
