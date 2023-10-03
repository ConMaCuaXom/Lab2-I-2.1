//Viết chương trình in ra các hình sau

for (int a =1;a<=6;a++)
{
    Console.WriteLine();
    for (int b=1;b<=a;b++)
    {
        Console.Write("*");    
    }
}
Console.WriteLine();


for (int a =6;a>=1;a--)
{
    Console.WriteLine();
    for (int b = 1; b <= a; b++)
    {
        Console.Write("$");
    }
}

Console.WriteLine();

for (int a = 0;a<=5; a++)
{
    Console.WriteLine();
    for (int b = 1;b<=11;b++)
    {
        if (b >= 6-a && b<= 6+a)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
}