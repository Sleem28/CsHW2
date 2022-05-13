// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();
Console.Write("Введите день недели: ");

int dayOfWeek = int.Parse(Console.ReadLine()?? "0");

if(dayOfWeek == 6 || dayOfWeek == 7)
    Console.WriteLine("Введенный день недели является выходным днем.");
else if(dayOfWeek > 7 || dayOfWeek < 1)
    Console.WriteLine("Введенное число не является номером дня недели!!!");
else
    Console.WriteLine("Введенный день недели не является выходным днем.");

