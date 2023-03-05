//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.Write("Введите число N = ");
int number = Convert.ToInt32(Console.ReadLine());

Cube(number);

void Cube(int num)
{
    int index = 1;
    while(index <= number)
    {
        int result = Convert.ToInt32(Math.Pow(index, 3));
        Console.WriteLine($"|{index}^3|{result}|");
        index++;
    }
}