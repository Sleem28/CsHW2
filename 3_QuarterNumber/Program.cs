// Задать номер четверти, показать диапазоны для возможных координат
// Просьба за try catch не ругать!!!
Console.Clear();
Console.WriteLine("Покажем возможные значения координат в зависимости от номера плоскости.");
Console.WriteLine();

Console.WriteLine("Введите номер координатной плоскости: ");
int planeNumber = 0;
try
{
 planeNumber = int.Parse(Console.ReadLine()?? "0");
}
catch
{
    Console.WriteLine("Нужно вводить только цифры!!!");  
}

if(planeNumber == 1)
    PrintResult("", "", planeNumber);
else if(planeNumber == 2)
    PrintResult(" минус", "", planeNumber);
else if(planeNumber == 3)
    PrintResult(" минус", " минус", planeNumber);
else if(planeNumber == 4)
    PrintResult("", " минус", planeNumber);    
else
    Console.WriteLine("Введенное число не является номером плоскости");

//-------------------------------Функция вывода на экран-----------------------------------------------------+
void PrintResult(string xSign, string ySign, int planeNumber)
{
    Console.WriteLine($"Возможные значения координат для плоскости с номером {planeNumber}: ");
    Console.WriteLine($"x от 0 до{xSign} бесконечности");
    Console.WriteLine($"y от 0 до{ySign} бесконечности");
}
//-----------------------------------------------------------------------------------------------------------+