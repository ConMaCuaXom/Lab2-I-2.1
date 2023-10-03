//Viết chương trình in ra các số có tổng 3 ký số là chẵn từ 100-999.

int a;
int b;
int c;
int d;

Console.WriteLine("Cac so co tong 3 chu so la chan tu 100-999 la: ");
for (a = 1;a<=9;a++)
{
    for (b = 0;b<=9;b++)
    {
        for (c = 0;c<=9;c++)
        {
            d = a + b + c;
            if (d % 2 == 0)
            {
                Console.Write(" "+a);
                Console.Write(b);
                Console.Write(c);

            }
        }
    }
}

