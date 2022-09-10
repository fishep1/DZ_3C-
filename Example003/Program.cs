//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("введите число n: ");

int n = Convert.ToInt32(Console.ReadLine());

for (int count = 1; count <= n; count++)
    Console.WriteLine($"{count}^{3} = {Math.Pow(count,3)}");