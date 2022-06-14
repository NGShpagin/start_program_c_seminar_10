// Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26

// int ValuseSetRec(int num1, int num2, int n)
// {
//     if (n == 1) return num1;
//     Console.Write($"{num1} ");
//     (num1, num2) = (num2, num2+num1);
//     return ValuseSteRec(num1, num2, n - 1);
// }

int ValuseSetRec(int num1, int num2, int n)
{
    if (n == 1) return num1;
    Console.Write($"{num1} ");
    // (num1, num2) = (num2, num2+num1);
    return ValuseSetRec(num2, num2+num1, n - 1);
}


Console.WriteLine(ValuseSetRec(3, 4, 5));