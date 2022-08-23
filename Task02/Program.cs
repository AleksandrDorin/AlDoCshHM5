// Слоник

int x = int.Parse(Console.ReadLine());
int i = 0;
while (i <= x)
{
    if (x >= 5)
    {
        x -= 5;
        i++;
    }
    else if (x >= 4)
    {
        x -= 4;
        i++;
    }
    else if (x >= 3)
    {
        x -= 3;
        i++;
    }
    else if (x >= 2)
    {
        x -= 2;
        i++;
    }
    else if (x >= 1)
    {
        x -= 1;
        i++;
    }
}

Console.WriteLine(i);
