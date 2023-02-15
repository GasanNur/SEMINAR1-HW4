//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число  ");      // вводим начальную информацию 
string inputValue = Console.ReadLine();     // для первых чисел присваиваем переменных из консоли

 int Value = Convert.ToInt32(inputValue);
 
 
 if (Value % 2 == 0)  
{
    System.Console.WriteLine($"Число {Value} четное число ");
}
else
{
    System.Console.WriteLine ($"Число {Value} не четные число");
}
  