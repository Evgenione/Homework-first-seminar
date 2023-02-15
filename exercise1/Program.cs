Console.WriteLine("введите чосло a"); 
int a = int.Parse(Console.ReadLine())!;
Console.WriteLine("введите чосло b"); 
int b = int.Parse(Console.ReadLine())!;
Console.WriteLine("введите чосло c"); 
int c = int.Parse(Console.ReadLine())!;
int max = a;

if(b > max) max = b;

if(c > max) max = c;

Console.WriteLine (max);