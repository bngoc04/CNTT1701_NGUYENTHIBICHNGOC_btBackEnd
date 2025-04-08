//Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.

using System;
// nhập số thứ nhất
Console.Write("Nhap so thu nhat: ");
double so1 = Convert.ToDouble(Console.ReadLine());

//  nhập số thứ hai
Console.Write("Nhap so thu hai: ");
double so2 = Convert.ToDouble(Console.ReadLine());

// Tính tổng và tích
double tong = so1 + so2;
double tich = so1 * so2;

Console.WriteLine("Tong cua hai so la: " + tong);
Console.WriteLine("Tich cua hai so la: " + tich);