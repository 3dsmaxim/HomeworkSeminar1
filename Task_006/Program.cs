Console.Clear();

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите число: ");
int MrA = Convert.ToInt32(Console.ReadLine());
int MrB = MrA % 2;
if (MrB == 0)
{
    Console.WriteLine("Число: " + MrA + " четное.");
}
else
{
    Console.WriteLine("Число: " + MrA + " нечетное.");
}