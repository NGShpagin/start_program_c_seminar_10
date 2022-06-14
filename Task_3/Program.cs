// Дано натуральное число N. 
// Выведите все его цифры по одной, в обратном порядке, разделяя их пробелами или новыми строками.

void ValuseSteRec(int n)
{
    if (n % 10 < 1) return;
    Console.Write($"{n % 10} ");
    ValuseSteRec(n / 10);
}

ValuseSteRec(3456);
Console.WriteLine();