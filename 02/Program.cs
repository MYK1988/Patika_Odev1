bool kontrol = false;
int n, m,sayac=1,sayi;
Console.Write("1. Pozitif Sayıyı Girin :");
kontrol = int.TryParse(Console.ReadLine(), out n);
Console.Write("2. Pozitif Sayıyı Girin :");
kontrol = int.TryParse(Console.ReadLine(), out m);
int[] sayilar=new int[0];

do
{
    Console.Write($"{sayac}. Sayıyı Girin : ");
    kontrol = int.TryParse(Console.ReadLine(),out sayi);
    Array.Resize(ref sayilar, sayilar.Length + 1);
    sayilar[sayilar.Length - 1] = sayi;

    sayac++;
} while (sayac<=n);

foreach (int i in sayilar)
{
    if (i==m||i%m==0)
    {
        Console.WriteLine(i);
    }
}

Console.ReadKey();

