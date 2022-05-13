// По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
Console.WriteLine("Проверим, является ли первое число квадратом второго!");

Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine()?? "0");

Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine()?? "0");

if(firstNum == secondNum * secondNum)
    Console.WriteLine("Первое число является квадратом второго.");
else
    Console.WriteLine("Первое число не является квадратом второго.");
