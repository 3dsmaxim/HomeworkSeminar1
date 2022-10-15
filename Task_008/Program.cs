Console.Clear();

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число от 4 до *как получится* ");
int MrA = Convert.ToInt32(Console.ReadLine());
int count = 0;
int MrB = MrA;

if (MrA >= 4)
{
    while (count <= (MrA / 2) + (MrA % 2) - 2)
    {
        if (MrA % 2 == 0)
        {

            Console.Write(MrB - 2 + ", ");
            MrB = MrB - 2;
            count++;
        }
        else
        {
            MrB = MrB + 1;
            while (count <= (MrA / 2) + (MrA % 2) - 2)
            {

                if (MrA % 2 == 1)
                {

                    Console.Write(MrB - 2 + ", ");
                    MrB = MrB - 2;
                    count++;


                }

            }

        }

    }
}

    else
{
    Console.WriteLine("Ну что ты что ты пишешь... от 4 ВКЛЮЧИТЕЛЬНО!!!");



}


