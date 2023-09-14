//Задача 64: Задайте значение N.
//Напишите программу, которая выводит все числа в промежутке от N до 1
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int n = InputNumbers("Введите N:");
число интервалов = 2;
PrintNumber (n, счетчик);
Консоль.Запись(1);

void PrintNumber(int n, int count)
{
    если (количество > n) возврат;
    PrintNumber(n, count + 1);
    Console.Write(count + ", ");
}

int InputNumbers (строковый ввод)
{
    Console.Write(вход);
    int output = Convert.ToInt32(Console.ReadLine());
    обратный вывод;
}