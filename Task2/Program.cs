// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void SumInNumb(int numb)
{
    string remake = numb.ToString();
    int legthNumb = remake.Length;
    int [] var = new int [legthNumb];
    int result = 0;
    for(int i = 0; i < legthNumb; i++)
    {
        var[i] = int.Parse(remake[i].ToString());
        result = result + var[i];
    }
    Console.WriteLine($"Сумма цифр числа {numb} равна {result}");
}
int EnterNumb(string text)
{
    Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int numb = EnterNumb("Введите число: ");
SumInNumb(numb);