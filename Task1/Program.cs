// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void FindSquare(int number1, int number2)
{
    double result = Math.Pow(number1,number2); 
    Console.Write($"Число {number1} в степени {number2} равно {result}");
}



int EnterData(string text)
{
   Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}



int number1 = EnterData("Введите первое число: ");
int number2 = EnterData("Введите второе число: ");
FindSquare(number1,number2);
