Console.Clear();

int xa = 40, ya = 1;
int xb = 1, yb = 20;
int xc = 80, yc = 20;

char symbol = '+';
Console.SetCursorPosition(xa, ya);
Console.WriteLine(symbol);

Console.SetCursorPosition(xb, yb);
Console.WriteLine(symbol);

Console.SetCursorPosition(xc, yc);
Console.WriteLine(symbol);

int x = xa, y = ya;
int count = 0;

while (count < 100000)
{
    int rand = new Random().Next(0, 3);
    if (rand == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    else if (rand == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    else
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine(symbol);
    count++;
}

Console.SetCursorPosition(0, yb + 1);
