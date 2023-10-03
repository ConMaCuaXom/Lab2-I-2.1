//Viết chương trình C# In ra các số nguyên tố từ 2-100 ( chú ý: số nguyên tố là số chỉ chia
//hết cho 1 và chính nó).



bool check;
Console.Write("Cac so nguyen to tu 2-100 la: ");
for (int i = 2; i <= 100; i++)
{
    check = true;
    for (int j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
        {
            check = false;
            break;
        }
    }
    if (check)
        Console.Write(" " + i);
}


