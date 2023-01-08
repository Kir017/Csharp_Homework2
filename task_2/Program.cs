Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number >= 1000)
{
  number /= 10;
}

if (number < 100)
{
  Console.WriteLine("Третьей цифры нет!!!");

}
else
{
    number = number % 10;
    Console.WriteLine(number);
}

