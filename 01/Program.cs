Console.Write("Pozitif Bir Sayı Girin : ");
int n=0;
int a=0;
int[] sayilar=new int[0];
int sayac = 1;

bool kontrol = false;
kontrol = int.TryParse(Console.ReadLine(), out n);
if (kontrol)
{
	do
	{
        Console.Write($"{sayac}. Sayıyı Girin : ");
        kontrol=int.TryParse(Console.ReadLine(), out a);
        if (kontrol)
        {
            Array.Resize(ref sayilar, sayilar.Length + 1);
            sayilar[sayilar.Length - 1] = a;
            sayac++;
        }
        
    } while (sayac<=n);

}

foreach (int item in sayilar)
{
    if (item % 2 == 0)
    {
        Console.WriteLine(item);
    }
}
Console.ReadKey();