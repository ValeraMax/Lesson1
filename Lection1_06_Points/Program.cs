Console.Clear();
//Console.SetCursorPosition(10, 2);
//Console.WriteLine("*");

int xa = 50;
int ya = 1;
int xb = 1;
int yb = 25;
int xc = 100;
int yc = 25;

Console.SetCursorPosition(xa, ya);
System.Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
System.Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
System.Console.WriteLine("*");

int x = xa, y = xb;

int count = 0;

while (count<2000)
{
    int what = new Random().Next(0, 3); // (0,1,2)
    if (what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }

    if (what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }

    if (what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }

    Console.SetCursorPosition(x, y);
    System.Console.WriteLine("*");
    count = count + 1;
}

