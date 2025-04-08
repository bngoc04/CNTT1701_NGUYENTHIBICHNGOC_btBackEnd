// Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.
using System;
// nhập một số nguyên dương
Console.Write("Nhap mot so nguyên dương: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0)
{
    Console.WriteLine("Vui long nhap mot so nguyên dương.");
}
else
{
    long giaiThua = 1;
    for (int i = 1; i <= n; i++)
    {
        giaiThua *= i;
    }

    Console.WriteLine($"Giai thua cua {n} la: {giaiThua}");
}
