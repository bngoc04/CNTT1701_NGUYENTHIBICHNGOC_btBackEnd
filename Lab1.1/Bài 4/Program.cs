// Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn hay không.

int x;
Console.Write("Nhap x = ");
try
{
    x = int.Parse(Console.ReadLine() ?? "");
    if (x % 2 == 0)
    {
        Console.WriteLine($"{x} là so chan");
    }
    else

    {
        Console.WriteLine($"{x} là so le");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Du lieu không hop le: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Loi:  " + ex.Message);
}


