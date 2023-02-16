using System;
Console.Write("A-> ");
int a = Int32.Parse(Console.ReadLine());
int b;
while (true)
{
    Console.Write ("B-> ");
    b = Int32.Parse(Console.ReadLine());
    if (a<=b)
        break;
}
for (int i = a; i <= b; i++)
    if (i % 2 == 0 && i % 2 == 0)
        Console.WriteLine (i);
    Console.ReadLine();