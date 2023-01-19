Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int remainder = 0;
int sum = 0;
while (number >= 1)
{
    remainder = number % 10;
    number = number / 10;
    sum = sum + remainder;
}
Console.WriteLine(sum);