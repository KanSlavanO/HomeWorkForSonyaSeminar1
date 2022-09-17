/*
// Задача 2: Напишите программу, которая на вход принимает 2 числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());

if(n > n2)
{
    Console.Write($"{n} максимальное значание, {n2} минимальное значение.");
}

else if(n < n2)
{
    Console.Write($" {n2} максимальное значение, {n} минимальное значение.");
}

else if(n == n2)
{
     Console.Write($" {n} равняется {n2}.");
}
Console.Write("End");
*/

/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int n3 = int.Parse(Console.ReadLine());

if((n > n2) && (n > n3))
{
    Console.Write($"{n} максимальное значание.");
}

else if((n2 > n) && (n2 > n3))
{
    Console.Write($"{n2} максимальное значание.");
}

else if((n3 > n) && (n3 > n2))
{
    Console.Write($"{n3} максимальное значание.");
}
else
{
    Console.Write($"{n} максимальное значание.");
}
Console.Write("End");
*/
/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if(n % 2 != 0)
{
    Console.Write($"{n} число нечётное.");
}
else
{
     Console.Write($"{n} число чётное.");
}
 Console.Write("End.");
*/
 //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i <= n; i++)
if (i % 2 != 1)
Console.Write("{0} ", i);
