//Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và chiều rộng.

using System;
Console.Write("Nhap chieu dai cua hinh chu nhat: ");
double chieuDai = Convert.ToDouble(Console.ReadLine());

Console.Write("Nhap chieu dai cua hinh chu nhat: ");
double chieuRong = Convert.ToDouble(Console.ReadLine());

// Tính diện tích
double dienTich = chieuDai * chieuRong;

Console.WriteLine("Dien tich cua hinh chu nhat la: " + dienTich);
