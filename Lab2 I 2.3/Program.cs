//Viết chương trình C# để giải phương trình bậc 2 (lưu ý a phải luôn !=0) 

double a, b, c, delta, x1, x2;
Console.WriteLine("Giai phuong trinh bac 2");
Console.WriteLine("===================================");
Console.Write("Nhap a: ");
do
{
    a = Convert.ToDouble(Console.ReadLine());
}
while (a == 0);

Console.Write("Nhap b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Nhap c: ");
c = Convert.ToDouble(Console.ReadLine());

delta = b * b - 4 * a * c;
if (delta < 0)
    Console.WriteLine("Phuong trinh vo nghiem!!");
if (delta == 0)
{
    x1 = x2 = -b / (2 * a);
    Console.WriteLine("Phuong trinh co nghiem kep la x1 = x2 = " + x1);
}
if (delta > 0)
{
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine("Phuong trinh co 2 nghiem la: ");
    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);
}


