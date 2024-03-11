double sinav = 0;
Console.Write("Sınav notunu giriniz:");

OkuSinav:
sinav = Convert.ToDouble(Console.ReadLine());
if (sinav < 0 || sinav > 100)
{
    Console.Write("Yanlış not bilgisi girdiniz.\nSınav notunuzu tekrardan giriniz:");
    goto OkuSinav;
}

Console.WriteLine("Doğru not girişi yaptınız.");
Console.ReadKey();