// Задать номер четверти, показать диапазоны для возможных координат
// Просьба за try catch не ругать!!!
Console.Clear();
Console.WriteLine("Покажем возможные значения координат в зависимости от номера плоскости.");
Console.WriteLine();

int planeNumber;
while (true)
{
    try
    {
        Console.WriteLine("Введите номер координатной плоскости: ");
        planeNumber = int.Parse(Console.ReadLine() ?? "0");
        break;
    }
    catch
    {
        Console.WriteLine("Нужно вводить только цифры!!!");
    }
}
//---------------------------Вариант с тернарным оператором------------------------------------------+
/*
bool isTrue = false;
isTrue = planeNumber == 1 ?
    PrintResult("", "", planeNumber):
(planeNumber == 2)? 
    PrintResult(" минус", "", planeNumber):
(planeNumber == 3)? 
    PrintResult(" минус", " минус", planeNumber): 
(planeNumber == 4)?
    PrintResult("", " минус", planeNumber):
(planeNumber < 1 || planeNumber > 4)? true:false;

if(isTrue) Console.WriteLine("Введенное число не является номером плоскости");
*/
//---------------------------------------------------------------------------------------------------+

if (planeNumber == 1)
    PrintResult("", "", planeNumber);
else if (planeNumber == 2)
    PrintResult(" минус", "", planeNumber);
else if (planeNumber == 3)
    PrintResult(" минус", " минус", planeNumber);
else if (planeNumber == 4)
    PrintResult("", " минус", planeNumber);
else if (planeNumber < 1 || planeNumber > 4)
    Console.WriteLine("Введенное число не является номером плоскости");
    

//-------------------------------Функция вывода на экран-----------------------------------------------------+
bool PrintResult(string xSign, string ySign, int planeNumber)
{
    Console.WriteLine($"Возможные значения координат для плоскости с номером {planeNumber}: ");
    Console.WriteLine($"x от 0 до{xSign} бесконечности");
    Console.WriteLine($"y от 0 до{ySign} бесконечности");
    return(false);
}
//-----------------------------------------------------------------------------------------------------------+