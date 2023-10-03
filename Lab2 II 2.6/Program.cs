//Viết chương trình csharp hiển thị ra hình sau:

for (int a = 0; a <= 9; a++)
{
    Console.WriteLine();
    for (int b = 1; b <= 19; b++)
    {
        if (b == 10)
        {
            int x = 1 + 2 * a;
            if (x > 9)
                x = x - 10;
            Console.Write(x);            
        }

        else
        {
            Console.Write(" ");
        }
    }
}

