Console.WriteLine("Введите ряд строк через запятую");
Console.WriteLine("Каждая строка может содержать люое количество символов:");
string[] array = Console.ReadLine()!.Split(',').ToArray();

var str = string.Join(" ", array);
Console.WriteLine(str);


