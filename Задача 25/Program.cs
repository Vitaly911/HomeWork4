Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int finishnumber = 1;
int i = 0;
if (number2 == 0)
{
    Console.WriteLine(1);
}
else
{
    while (i < number2)
    {
        finishnumber = finishnumber * number;
        i++;
    }
    Console.WriteLine(finishnumber);
}