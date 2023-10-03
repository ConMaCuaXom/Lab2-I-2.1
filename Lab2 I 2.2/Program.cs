//Nhập vào một ký tự, thông báo ra màn hình đó là nguyên âm hay phụ âm

char ch;
Console.Write("Nhap ky tu: ");
ch = Convert.ToChar(Console.Read());

switch (ch)
{
    case 'a':
        Console.WriteLine("{0} la nguyen am.", ch);
        break;
    case 'e':
        Console.WriteLine("{0} la nguyen am.", ch);
        break;
    case 'i':
        Console.WriteLine("{0} la nguyen am.", ch);
        break;
    case 'o':
        Console.WriteLine("{0} la nguyen am.", ch);
        break;
    case 'u':
        Console.WriteLine("{0} la nguyen am.", ch);
        break;
    default:
        Console.WriteLine("{0} la phu am.", ch);
        break;
}
