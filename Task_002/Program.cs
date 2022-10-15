Console.Clear();
//Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("В введите два числа чтобы понять какое из них больше");

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine(numberA + " > " + numberB + " max = " + numberA + ",  min = " + numberB );
}
if (numberA < numberB)
{
    Console.WriteLine(numberA + " < " + numberB + " max = " + numberB + ",  min = " + numberA );
}