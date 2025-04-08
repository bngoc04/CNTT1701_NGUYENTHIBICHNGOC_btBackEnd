// Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.

using System;
static bool LaSoNguyenTo(int n)
{
    if (n < 2)
        return false;
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}

Console.Write("Nhap mot so nguyên: ");
int so = Convert.ToInt32(Console.ReadLine());
if (LaSoNguyenTo(so))
{
    Console.WriteLine($"{so} là so nguyên to.");
}
else
{
    Console.WriteLine($"{so} không phai là so nguyên to.");
}