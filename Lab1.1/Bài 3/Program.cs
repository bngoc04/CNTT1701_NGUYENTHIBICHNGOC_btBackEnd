//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
// Công thức: F = (C * 9 / 5) + 32

using System;
// Yêu cầu người dùng nhập nhiệt độ theo độ C
Console.Write("Nhap nhiet đo (°C): ");
double doC = Convert.ToDouble(Console.ReadLine());

// Chuyển đổi sang độ F
double doF = (doC * 9 / 5) + 32;

Console.WriteLine("Nhiet đo tương ung (°F): " + doF);
