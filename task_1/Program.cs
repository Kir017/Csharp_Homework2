Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (100 <= number && number <= 999)
{
  number /= 10;
  number = number % 10;
  Console.WriteLine(number);
}
else
{
Console.WriteLine("Нужно ввести трехзначное число");
}