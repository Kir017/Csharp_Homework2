Console.Write("Введите число дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (1 <= number&& number <= 7)
{
    if (number > 5)
    {
      Console.WriteLine(" Ура, ВЫХОДНОЙ!!! ");
    }
    else
    {
       Console.WriteLine(" Это рабочий день.");
    }

}
else
{
   Console.WriteLine(" Вы ввели не верные данные. поддерживается ввод числа от 1 до 7");
}