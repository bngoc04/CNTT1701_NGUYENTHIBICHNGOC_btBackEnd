// Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
// (Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho 400).

using System;
//  nhập một năm
Console.Write("Nhap mot nam: ");
int nam = Convert.ToInt32(Console.ReadLine());

// Kiểm tra năm nhuận
if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
{
    Console.WriteLine($"{nam} là nam nhuan.");
}
else
{
    Console.WriteLine($"{nam} không phai la năm nhuan.");
}