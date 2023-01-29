// Задача 2: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе. Реализовать 
// через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promt(string message)
{
    System.Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Promt("Введите число ");
//Нужно число разложить на разряды чтобы можно было сложить отдельно цифры

int SumNumber(int sumer)
{

    int sum = 0;
    while (number != 0)//условие пока число не равно 0
    {
        sum = sum + number % 10;//создал переменную sum 
        number = number / 10;//убераю разряд
    }
    return sum;//возвращаю значение
}
Console.WriteLine($"Сумма чисел равна:  {SumNumber(number)}");//вывожу результат

