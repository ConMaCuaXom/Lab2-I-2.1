//Viết chương trình nhập vào số nguyên dương là số giây, in ra định dạng sau hh:mm: ss.Ví
//dụ số giây nhập vào là 350 thì in ra là 00:05:50.



int x;
int h, m, s, mmm;
Console.WriteLine("Nhap vao so giay: ");
x = Convert.ToInt32(Console.ReadLine());
s = x % 60;

mmm = x / 60;
m = mmm % 60;
h = mmm / 60;

Console.WriteLine("So gio quy doi la: {0}:{1}:{2}", h, m, s);






