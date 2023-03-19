Console.WriteLine("Введите ряд строк через запятую");
Console.WriteLine("Каждая строка может содержать люое количество символов:");
string[] array = Console.ReadLine()!.Split(',').ToArray();

var str = string.Join(" ", array);
Console.WriteLine(str);

int len = array.Length;
string[] array_element_3 = new string[len];
for(int i = 0; i < len; i++)
{
    int len_element_array = array[i].Length;
    if (len_element_array <= 3)
        {
            array_element_3[i] = array[i];
        }
}
