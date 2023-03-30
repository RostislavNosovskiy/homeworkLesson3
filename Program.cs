/*** Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
Console.Clear();
Console.WriteLine("Введите пятизначное число:");
int N = int.Parse(Console.ReadLine());
while ((N>9999) && (N<10000))
{
    Console.WriteLine("Попробуйте ввести пятизначное число ещё раз:");
     N = int.Parse(Console.ReadLine());
}
if (((N%100)%10 == (N/1000)/10) && ((N%100)/10) == (N/1000)%10 )
{
    Console.WriteLine($"{N} -> да");
}
else 
Console.WriteLine($"{N} -> нет");
