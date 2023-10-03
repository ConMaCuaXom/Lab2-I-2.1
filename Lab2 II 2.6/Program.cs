//Viết chương trình csharp hiển thị ra hình sau:

int h, d;
Console.Write("Nhap vao chieu cao cua tam giac: ");
h = Convert.ToInt32(Console.ReadLine());
d = 2 * h - 1;
for (int a = 1; a <= h; a++)
{
    Console.WriteLine();
    for (int b = 1; b <= d; b++)
    {
        int x = 2 * a - 1;
        if (b == h)
        {           
            if (x > 9)
                x = x - ((x / 10) * 10);
            Console.Write(x);            
        }

        if (b > h - a && b < h + a)
        {
            for (int c = 1;c<=a;c++)
            {
                if (b == h - c || b == h + c)
                {
                    int y = x - c;
                    if (y > 9)
                    {
                        y = y - ((y / 10) * 10);
                    }
                    Console.Write(y);
                }
                
            }
        }

        else
        {
            Console.Write(" ");
        }
    }
}

