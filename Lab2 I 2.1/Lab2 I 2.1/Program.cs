// Nhập vào tên thuê bao, số điện trên công tơ sau đó tính cước theo quy ước sau.
//- Nếu số phút gọi <=30 số thì cước phí tính 30$.
//- Nếu từ 30-50 số thì số trong khoảng (30-50) sẽ tính theo 1.2$ cho mỗi số.
//- Nếu trên 50 số thì số trên 50 được tính theo 1.5$ cho mỗi số
//- In ra màn hình toàn bộ thông tin.


string name;
float number;
double money;

Console.Write("Nhap ten thue bao: ");
name = Console.ReadLine();
Console.Write("Nhap so dien: ");
number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("========================");

Console.WriteLine("Thue bao: " + name);
Console.WriteLine("So dien: " + number);
if (number <= 30)
{
    money = 30;
    Console.WriteLine("So tien can thanh toan:$" + money);
}

if (number > 30 && number <= 50)
{
    money = 30 + (number - 30) * 1.2;
    Console.WriteLine("So tien can thanh toan:$" + money);
}

if (number > 50)
{
    money = 30 + 20 * 1.2 + (number - 50) * 1.5;
    Console.WriteLine("So tien can thanh toan:$" + money);
}
