// Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.

using System;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Bang cuu chương {0}:", i);
    for (int j = 1; j <= 10; j++)
{
    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
}
    Console.WriteLine(); 
}