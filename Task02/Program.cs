// Слоник

int x = int.Parse(Console.ReadLine());
int k = 0;
for (int i = 5; i > 0; i--)
{
    k += x / i;
    x = x % i;
}
Console.WriteLine(k);
