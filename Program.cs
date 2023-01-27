//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();				                // очистка консоли

Console.WriteLine("Введите число: ");		// ввод числа
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)                           //  определяем остаток от деления на 2
    Console.WriteLine($"Число {num} - чётное.");
else
    Console.WriteLine($"Число {num} - нечётное.");