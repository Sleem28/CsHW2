// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();
Console.WriteLine("Покажем возможные значения координат в зависимости от номера плоскости.");
Console.WriteLine();

Console.WriteLine("Введите номер координатной плоскости: ");
int planeNumber = int.Parse(Console.ReadLine()?? "0");

if(planeNumber == 1)
{
    Console.WriteLine($"Возможные значения координат для плоскости с номером {planeNumber}: ");
    Console.WriteLine("x от 0 до бесконечности");
    Console.WriteLine("y от 0 до бесконечности");
}
else if(planeNumber == 2)
{
    Console.WriteLine($"Возможные значения координат для плоскости с номером {planeNumber}: ");
    Console.WriteLine("x от 0 до минус бесконечности");
    Console.WriteLine("y от 0 до бесконечности");
}
else if(planeNumber == 3)
{
    Console.WriteLine($"Возможные значения координат для плоскости с номером {planeNumber}: ");
    Console.WriteLine("x от 0 до минус бесконечности");
    Console.WriteLine("y от 0 до минус бесконечности");
}
else if(planeNumber == 4)
{
    Console.WriteLine($"Возможные значения координат для плоскости с номером {planeNumber}: ");
    Console.WriteLine("x от 0 до бесконечности");
    Console.WriteLine("y от 0 до минус бесконечности");
}    
else
    Console.WriteLine("Введенное число не является номером плоскости");
