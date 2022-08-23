// Театральная площадь
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int a = int.Parse(Console.ReadLine());

int x, y;
x = n / a;
y = m / a;
if (n % a != 0)
    x++;
if (m % a != 0)
    y++;
Console.WriteLine(x * y);