Console.Clear();

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите число: ");
int mrA = Convert.ToInt32(Console.ReadLine());
int mrB = mrA % 2;
if (mrB == 0)
{
    Console.WriteLine("Число: " + mrA + " четное.");
}
else
{
    Console.WriteLine("Число: " + mrA + " нечетное.");
}