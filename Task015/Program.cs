// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

string CheckDate(int number)
{
    string result;
    if (number <= 5)
    {
        result = "будний день";
    }
    else
    {
        result = "выходной день";
    }
    return result;
}

Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num <= 7)
{
    Console.WriteLine(num + " -> " + CheckDate(num));
}
else
{
    Console.WriteLine("Такого дня нет");
}