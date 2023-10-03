//Viết chương trình C# tính tổng các số chẵn và không chia hết cho 3 từ 1-100

int sum = 0;
for (int i = 0; i <= 100; i++)
{
    if (i % 2 == 0 && i % 3 != 0)
    {
        sum = sum + i;
    }
}
Console.WriteLine("Tong so chan va ko chia het cho 3 la: " + sum);



