// Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.

using System;
// nhập một số
Console.Write("Nhap mot so: ");
double so = Convert.ToDouble(Console.ReadLine());

// Kiểm tra số dương, âm hay số không
if (so > 0)
{
    Console.WriteLine("La so dương.");
}
else if (so < 0)
{
    Console.WriteLine("La so âm.");
}
else
{
    Console.WriteLine("La so không.");
}