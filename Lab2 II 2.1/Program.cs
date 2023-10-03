//Viết chương trình nhập vào năm x tháng y sau đó in ra số ngày trong tháng năm đó.


int x, y;

Console.Write("Nhap vao so nam: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap vao so thang: ");
y = Convert.ToInt32(Console.ReadLine());

switch (y)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("Thang {0} nam {1} co 31 ngay", y, x);
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("Thang {0} nam {1} co 30 ngay", y, x);
        break;
    case 2:
        if (x % 4 == 0)
            Console.WriteLine("Thang 2 nam {0} co 29 ngay", x);
        else
            Console.WriteLine("Thang 2 nam {0} co 28 ngay", x);
        break;
    default:
        Console.WriteLine("Nhap sai so thang!!");
        break;
        
}
