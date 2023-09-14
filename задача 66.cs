//Задача 66: Задайте значения M и N.
//Напишите программу, которая найдёт количество исходных элементов в промежутке от M до N.
//М = 1; Н = 15 -> 120
//М = 4; Н = 8. -> 30

int m = InputNumbers("Введите M:");
int n = InputNumbers("Введите N:");
интервал темп = м;

если (м > п)
{
    м = п;
    n = температура;
}

PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int summ)
{
    сумма = сумма + п;
    если (n <= m)
    {
        Console.Write($"Сумма элементов = {summ} ");
        возвращаться;
    }
    PrintSumm(m, n - 1, сумма);
}

int InputNumbers (строковый ввод)
{
    Console.Write(вход);
    int output = Convert.ToInt32(Console.ReadLine());
    обратный вывод;
}