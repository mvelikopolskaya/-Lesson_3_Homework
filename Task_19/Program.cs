// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (9999 < number && number < 100000)
{
    if(Reverse(number)) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Ошибка ввода");

bool Reverse(int num)
{
   int num1 = num / 10000;
   int num2 = num / 1000 % 10;
   int num3 = num /100 % 10;
   int num4 = num / 10 % 10;
   int num5 = num % 10;
   if(num1 == num5 && num2 == num4) return true;
   else return false;
}
