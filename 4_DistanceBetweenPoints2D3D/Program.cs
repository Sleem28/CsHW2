// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
Console.WriteLine("Найдем расстояние между точкими.\n\nВыберите количество плоскостей пространства, 2 или 3: ");
while(true)
{
int planesAmount = int.Parse(Console.ReadLine()?? "0");

    if(planesAmount == 2) // 2D
    {
        int x1, x2, y1, y2;
        Console.WriteLine("Расчет производим для 2D.");
        x1 = GetValue("x первой");
        y1 = GetValue("у первой");
        x2 = GetValue("x второй");
        y2 = GetValue("у второй"); 

        double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));

        Console.WriteLine($"Расстояние между двумя точками на плоскости равно: {Math.Abs(result)}.");
        return;
    }
    else if(planesAmount == 3) // 3D
    {
        int x1, x2, y1, y2, z1, z2;
        Console.WriteLine("Расчет производим для 3D.");
        x1 = GetValue("x первой");
        y1 = GetValue("у первой");
        z1 = GetValue("z первой");
        x2 = GetValue("x второй");
        y2 = GetValue("у второй"); 
        z2 = GetValue("z второй");

        double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));

        Console.WriteLine($"Расстояние между двумя точками в пространстве равно: {Math.Abs(result)}.");
        return;
    }
    else
    {
        Console.WriteLine("Введенное число плоскостей не корректно для проведения расчетов!!! Введите корректное количество плоскостей, 2 или 3!!!");
    }
}
//----------------------------------------------------Функция для получения значения с клавиатуры----------------------------------------------------+
int GetValue(string text)
{   
    Console.WriteLine($"Введите значение координаты {text} точки: ");
    int value = int.Parse(Console.ReadLine()?? "0");
    return(value);
}
//---------------------------------------------------------------------------------------------------------------------------------------------------+