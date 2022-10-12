Console.WriteLine("Введите значение ");
string str1 = Console.ReadLine();

Console.WriteLine("Введите значение ");
string str2 = Console.ReadLine();

Console.WriteLine("Введите значение ");
string str3 = Console.ReadLine();

Console.WriteLine("Введите значение ");
string str4 = Console.ReadLine();

Console.WriteLine("Введите значение ");
string str5 = Console.ReadLine();


string[] array = { str1, str2, str3, str4, str5 };

Console.WriteLine($"[{string.Join(", ", array)}]");

string[] array2 = new string[array.Length];

int count = 0;

for (int i = 0; i < array.Length; i++)
{

    if (array[i].Length <= 3)
    {
        array2[count] = array[i];
        count++;
    }

}

Console.WriteLine();
Console.WriteLine("Результат:");

string[] array3 = new string[count];

for (int i = 0; i < count; i++)
{
    array3[i] = array2[i];
}
Console.WriteLine($"[{string.Join(", ", array3)}]");





