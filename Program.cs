 /*                        Задача 41
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше
0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3


int Prompt(string message)
{
    System.Console.WriteLine(message);
    string a = Console.ReadLine();
    int b = int.Parse(a);
    return (b);
}
int[] FillArray(int Length)
{
    System.Console.WriteLine($"Введите {Length} элемент(ов) массива");
    int[] Array = new int[Length];
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.WriteLine($"Введите элемент массива {i + 1}");
        string c = Console.ReadLine();
        Array[i] = Convert.ToInt32(c);
    }
    return Array;
}
void PrintArray(int[] Array)
{
    System.Console.Write("{");
    for (int i = 0; i < Array.Length - 1; i++)
    {
        System.Console.Write($"{Array[i]}, ");
    }
    System.Console.Write($"{Array[Array.Length - 1]}");
    System.Console.WriteLine("}");
}
int Check(int[] Array)
{
    int result = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
            result = result+1;
        }
    }
    return result;
}
int length = Prompt("Введите количество элементов массива");
int[] array = FillArray(length);
PrintArray(array);
Check(array);
System.Console.WriteLine($"Количество чисел больше 0 = {Check(array)}");

____________________________________________________________________________________

                            Задача 43
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями
y = k1 * x + b1,
y = k2 * x + b2;
значения b1, k1, b2 и k2
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    System.Console.WriteLine((message));
    string? a = (Console.ReadLine());
    double b = double.Parse(a);
    return b;
}
double k1 = Prompt("Введите число k1");
double b1 = Prompt("Введите число B1");
double k2 = Prompt("Введите число k2");
double b2 = Prompt("введите число b2");

double FindX(double k1, double k2, double b1, double b2)

{
    double x = (b2-b1)/(k1-k2);
    return x;
}

double FindY(double k1, double b1, double x)
{
    double y = k1*x+b1;
    return y;
}

double x = FindX(k1, k2, b1, b2);
double y = FindY(k1, b1, x);

void ResultStatement()
{
if (k1 == k2 && b1 == b2)
{
    System.Console.WriteLine("Прямые совпадают, существует бесконечное еоличество решений");
}
else if(k1 == k2)
{
    System.Console.WriteLine(" Прямые параллельны, решения нет");
}
else
{
    System.Console.WriteLine($" x = {x}, y = {y}");
}
}

ResultStatement();
*/