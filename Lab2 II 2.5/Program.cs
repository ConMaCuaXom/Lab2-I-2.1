//Viết chương trình nhập vào 3 số nguyên a, b, c.
//a. Xét xem a, b, c có tạo thành độ dài 3 cạnh của một tam giác không?.
//b. Nếu là a, b, c là độ dài 3 cạnh của tam giác thì xét xem tam giác gì.

int a, b, c;
Console.Write("Nhap so a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap so b: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap so c: ");
c = Convert.ToInt32(Console.ReadLine());

if (a+b>c && a+c>b && b + c > a)
{
    Console.WriteLine("{0},{1},{2} la 3 canh cua 1 tam giac", a, b, c);
}
else
    Console.WriteLine("{0},{1},{2} khong la 3 canh cua 1 tam giac", a, b, c);

if (a*a == b*b+c*c || b*b == a*a + c*c || c*c == a*a + b * b)
{
    Console.WriteLine("{0},{1},{2} la 3 canh cua 1 tam giac vuong", a, b, c);
}

if (a == b || b == c || a==c)
{
    if (a == b && b == c)
    {
        Console.WriteLine("{0},{1},{2} la 3 canh cua 1 tam giac deu", a, b, c);
    } else
    Console.WriteLine("{0},{1},{2} la 3 canh cua 1 tam giac can", a, b, c);
}



