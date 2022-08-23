// Красивый год
int year = int.Parse(Console.ReadLine());

void NextDiffYear(int year)
{
    for (int y = year + 1; ; y++)
    {
        int a = y / 1000;
        int b = y / 100 % 10;
        int c = y / 10 % 10;
        int d = y % 10;
        if (a != b && b != c && c != d && a != c && a != d && b != d)
        {
          Console.WriteLine(y); 
            return;
        }
    }
    
}
NextDiffYear(year);
