//Viết chương trình C# khai báo và khởi tạo một mảng tên, dùng foreach để in mỗi tên trên
//một dòng

string[] names = { "Thang", "Long", "Ha", "Noi" };
Console.WriteLine("Danh sach sinh vien: ");
foreach (string name in names)
{
    Console.WriteLine(name);
}