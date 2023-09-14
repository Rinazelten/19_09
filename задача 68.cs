//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int m = InputNumbers("Введите M:");
int n = InputNumbers("Введите N:");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
    если (m == 0) вернуть n + 1;
    иначе, если (n == 0) вернуть Ack(m - 1, 1);
    иначе верните Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers (строковый ввод)
{
    Console.Write(вход);
    int output = Convert.ToInt32(Console.ReadLine());
    обратный вывод;
}