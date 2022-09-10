// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число A:");

int a = Convert.ToInt32(Console.ReadLine());

int num1 = a / 10000;
//Console.WriteLine(num1);

int num2 = (a / 1000) % 10;
//Console.WriteLine(num2);

int num3 = (a / 10) % 10;
//Console.WriteLine(num3);

int num4 = a % 10;
//Console.WriteLine(num4);

if (num1 == num4 && num2 == num3)
    Console.WriteLine("Это число является палиндромом");
else 
    Console.WriteLine("Это число не является палиндромом");
