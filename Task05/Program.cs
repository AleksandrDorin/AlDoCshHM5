// Солдат и бананы


Console.Clear();
Console.Write("Цена за первый банан: ");
int k = int.Parse(Console.ReadLine());
Console.Write("Нужно купить бананов: ");
int w = int.Parse(Console.ReadLine());
Console.Write("У солдата $ : ");
int n = int.Parse(Console.ReadLine());
int i = 1;
int res = 0;
while (i <= w)
{
    res += k * i;
    i++;
}
Console.Write($"У солдата {n}$, нужная сумма {res}$, он должен одолжить у однополчанина {res - n}$ ");