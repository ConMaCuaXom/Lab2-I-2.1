/* Viết chương trình C# với các yêu cầu sau.
             - Nhập vào số tiền gửi, lãi suất ngân hàng (tính theo năm) và số tháng gửi.
             - Tính và xuất số dư cuối kỳ và tiền lãi cuối kỳ, biết rằng:
             o Lãi suất tháng = (Lãi suất năm/ 12)/ 100
             o Tiền lãi tháng = Tiền gốc * Lãi suất tháng
             o Tiền lãi mỗi tháng sẽ được gộp chung vào tiền gốc
             o Tiền lãi cuối kỳ sẽ được tích lũy tiến từ tiền lãi mỗi tháng + tiền gốc. */

Console.WriteLine("Nhap so tien gui: ");
int tiengui = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap lai suat ngan hang: ");
int laisuat = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap so thang gui: ");
int thoigiangui = Convert.ToInt32(Console.ReadLine());

double lst = (laisuat / 12);
double total = tiengui;
double sodu = 0;
for (int i = 0; i < thoigiangui; i++)
{
    total = (total + total * ((laisuat/12) / 100));
    sodu = (total - tiengui);
    Console.Write("Tong tien thang thu {0} la: ", i + 1);
    Console.WriteLine(total);
    Console.Write("Tien lai cua thang thu {0} la: ", i + 1);
    Console.WriteLine(sodu);
}



Console.WriteLine("asdasdad");
Console.WriteLine("asdasdad");
Console.WriteLine("asdasdad");
Console.WriteLine("asdasdad");


